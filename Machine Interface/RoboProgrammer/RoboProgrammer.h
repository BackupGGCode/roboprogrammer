/*****************************************************************
 *        Revision History                                       *
 *          * 1.0     04-2010                                    *
 *          * 1.5     08-2010                                    *
 *            -> Servo instead of SoftwareServo                  *
 *            -> Simple Delays instead of ServoDelays            *
 *            -> "ReleaseOneChip()" Added                        *
 *            -> Serial Response Added                           *
 *          * 1.6    08-2010                                     *
 *            -> FixChip() Added                                 *
 *            -> SetState() Added                                *
 *                                                               *
 *                                                               *
 *                                                               *
 *                                                               *
 *                                                               *
 *                                                               *
 *                                                               *
 *                                                               *
 *                                                               *
 *                                                               *
 *                                                               *
 *****************************************************************/


#define rotorServoPin 4
#define zifServoPin 6
#define headServoPin 2
#define queueServoPin 3
#define fixerServoPin 5
#define pumpPin 14

#define rotorCenterPos 79
#define rotorRightPos 175
#define rotorLeftPos 0
#define rotorLeftDumpPos 40
#define rotorLeftRailPos 0

#define zifLockValue 60
#define zifUnlockValue 125

#define queueBackValue 3
#define queueFrontValue 12

#define headUpValue 0
#define headDownValueRight 190
#define headDownValueCenter 150
#define headDownValueLeft 90


#define fixerRelaxValue 60
#define fixerSetValue 15

#define responseOK 'o'
#define responseError 'e'

#define IdleState 1
#define WorkingState 2

#define maxIdleMillis 120000
//120000 ms = 120 seconds = 2 minutes
