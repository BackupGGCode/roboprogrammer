/************************************************************
 *                                                          *
 *              RoboProgrammer v1.6   08-2010               *
 *                                                          *
 *    Automatic (robotic) chip programmer (avr, pic etc)    *
 *                                                          *
 *    By [Dexter's Lab GR]                                  *
 *    Copyright (c) Tsamakos Alexandros                     *
 *                                                          *
 *    9600 bps                                              *
 *  'u' = unload chip | 'l' = load new chip  |  'd' = dump  *
 *     'i' = set Idle State  |  'w' = set Working State     *
 *                   'a' = respond ok                       *
 *                                                          *
 *    responses:                                            *
 *        'o' = ok  |  'e' = error                          *
 *                                                          *
 ************************************************************/


#include "RoboProgrammer.h"
#include "GRoboduinoBoard.h"
#include <Servo.h>

GRoboduino brd;
Servo rotorServo;
Servo zifServo;
Servo headServo;
Servo queueServo;
Servo fixerServo;

byte currentState = 0;
unsigned long workingTimeStamp = 0;

void setup()
{
  Serial.begin(9600);
  pinMode(pumpPin, OUTPUT);
  SetState(IdleState);
}

boolean SetState(byte aState)
{
  if (aState == WorkingState)
    workingTimeStamp = millis();

  if (currentState == aState)
    return true;

  switch (aState)
  {
	  case IdleState: 
	    rotorServo.detach();
	    zifServo.detach();
	    headServo.detach();
	    queueServo.detach();
	    fixerServo.detach();
	
	    digitalWrite(rotorServoPin, LOW);
	    digitalWrite(zifServoPin, LOW);
	    digitalWrite(headServoPin, LOW);
	    digitalWrite(queueServoPin, LOW);
	    digitalWrite(fixerServoPin, LOW);
	
	    brd.beep();
	    brd.setLed(ON);
	    break;
	
	  case WorkingState:
	    rotorServo.attach(rotorServoPin, 500, 2500);
	    zifServo.attach(zifServoPin);
	    headServo.attach(headServoPin, 544, 2500);
	    queueServo.attach(queueServoPin);
	    fixerServo.attach(fixerServoPin);
	
	    queueServo.write(queueBackValue);
	    fixerServo.write(fixerRelaxValue);
	    SetPumpOff();
	    SetZifUnlocked();
	    SetHeadUp();
	    SetRotorPos(rotorCenterPos);
	
	    Beep();
	    delay(70);
	    Beep();
	    delay(70);
	    Beep();
	    brd.setLed(OFF);
	    break;
	
	  default:
	    break;
  }

  currentState = aState;
  return true;
}

void Beep()
{
  brd.playNote('C', 300);
}

void SendResponse(boolean aOK)
{
  Serial.write(aOK ? responseOK : responseError);
}

void SmallServoDelay()
{
  delay(1300);
}

void BigServoDelay()
{
  delay(1800);
}

void SetRotorPos(int aPosition)
{
  int servoPos = rotorServo.read();
  if (aPosition > servoPos)
    for (int i = servoPos; i <= aPosition; i++)
    {
      rotorServo.write(i);
      delay(20);
    }
  else
    for (int i = servoPos; i >= aPosition; i--)
    {
      rotorServo.write(i);
      delay(20);
    }
}

void SetZifLocked()
{
  zifServo.write(zifLockValue);
  SmallServoDelay();
}

void SetZifUnlocked()
{
  zifServo.write(zifUnlockValue);
  SmallServoDelay();
}

void SetHeadDown()
{
  int pos = 0;

  switch (rotorServo.read())
  {
	  case rotorCenterPos: 
	    pos = headDownValueCenter;
	    break;
	  case rotorRightPos: 
	    pos = headDownValueRight;
	    break;
	  case rotorLeftPos: 
	    pos = headDownValueLeft;
	    break;
	  default: 
	    pos = headDownValueRight;
	    break;
  }

  headServo.write(pos);
  BigServoDelay();
}

void SetHeadUp()
{
  headServo.write(headUpValue);
  SmallServoDelay();
}

void ReleaseOneChip()
{
  queueServo.write(queueFrontValue);
  delay(2000);
  queueServo.write(queueBackValue);
  delay(1000);
}

void FixChip()
{
  fixerServo.write(fixerRelaxValue);
  delay(700);
  fixerServo.write(fixerSetValue);
  SmallServoDelay();
  fixerServo.write(fixerRelaxValue);
}

void SetPumpOn()
{
  digitalWrite(pumpPin, true);
  delay(1000);
}

void SetPumpOff()
{
  digitalWrite(pumpPin, false);
  delay(1000);
}

boolean LoadNewChip()
{
  SetState(WorkingState);

  SetPumpOff();
  SetZifUnlocked();
  SetRotorPos(rotorRightPos);
  ReleaseOneChip();
  FixChip();
  SetHeadDown();
  SetPumpOn();
  SetHeadUp();
  SetRotorPos(rotorCenterPos);
  SetHeadDown();
  SetPumpOff();
  SetZifLocked();
  SetHeadUp();

  return true;
}

boolean UnloadChip()
{
  SetState(WorkingState);

  SetPumpOff();
  SetZifUnlocked();
  SetRotorPos(rotorCenterPos);
  SetHeadDown();
  SetPumpOn();
  SetHeadUp();
  SetRotorPos(rotorLeftPos);
  SetHeadDown();
  SetPumpOff();
  SetRotorPos(rotorLeftDumpPos);
  SetHeadUp();

  return true;
}

boolean DumpChip()
{
  SetState(WorkingState);

  SetPumpOff();
  SetZifUnlocked();
  SetRotorPos(rotorCenterPos);
  SetHeadDown();
  SetPumpOn();
  SetHeadUp();
  SetRotorPos(rotorLeftDumpPos);
  SetHeadDown();
  SetPumpOff();
  SetHeadUp();

  return true;
}

char c = 0;
void loop()
{
  while (!Serial.available())
  {
    if (currentState == WorkingState)
    {
      if ((millis() - workingTimeStamp) >= maxIdleMillis)
        SetState(IdleState);
    }
  }

  c = Serial.read();

  switch (c)
  {
	  case 'l': 
	    SendResponse(LoadNewChip());
	    break;
	  case 'u': 
	    SendResponse(UnloadChip());
	    break;
	  case 'd':
	    SendResponse(DumpChip());
	    break;
	  case 'i':
	    SendResponse(SetState(IdleState));
	    break;
	  case 'w':
	    SendResponse(SetState(WorkingState));
	  case 'a':
	    SendResponse(true);
	  default: 
	    break;
  }

  BigServoDelay();
  BigServoDelay();
}
