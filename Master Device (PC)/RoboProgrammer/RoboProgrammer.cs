using System;
using System.Collections.Generic;
using System.Text;
using System.IO.Ports;
using System.Threading;

namespace RoboProgrammer
{
    class RoboProgrammerClass
    {
        private SerialPort _serialPort = null;
        private string _port = "";

        public string Port
        {
            get { return _port; }
            set 
            {
                SerialClose();
                _port = value; 
            }
        }

        public RoboProgrammerClass()
        {
            _serialPort = new SerialPort();
            _serialPort.BaudRate = 9600;
            _serialPort.DataBits = 8;
            _serialPort.StopBits = StopBits.One;
        }

        ~RoboProgrammerClass()
        {
            SerialClose();
            _serialPort.Dispose();
            _serialPort = null;
        }

        private void SerialOpen()
        {
            if (_serialPort.IsOpen)
                _serialPort.Close();
            _serialPort.PortName = _port;

            _serialPort.Open();
        }

        public void SerialClose()
        {
            if (_serialPort.IsOpen)
            {
                _serialPort.Close();
            }
        }

        private void SerialWrite(string p)
        {
            if (!_serialPort.IsOpen)
                SerialOpen();

            _serialPort.Write(p);
        }

        const int iTimeOutMax = 4 * 35; //35 sec
        private bool SerialWaitForOK()
        {
            if (_serialPort.IsOpen)
            {
                int iTimeOut = 0;
                while ((_serialPort.BytesToRead == 0) && (iTimeOut <= iTimeOutMax))
                {
                    iTimeOut++;
                    Thread.Sleep(250);
                }
                if (iTimeOut >= iTimeOutMax)
                    return false;
                else
                {
                    char[] retValue = new char[1];
                    _serialPort.Read(retValue, 0, 1);
                    return (retValue[0] == 'o');
                }
            }
            else
                return false;
        }

        private void SendCommand(string aCommand)
        {
            SerialWrite(aCommand);
            if (!SerialWaitForOK())
                throw new Exception(string.Format("An error occured while sending command \"{0}\"! RoboRecorder did not respond!", aCommand));
        }

        public void LoadChip()
        {
            SendCommand("l");
        }

        public void UnloadChip()
        {
            SendCommand("u");
        }

        public void DumpChip()
        {
            SendCommand("d");
        }

        public void SetWorkingState()
        {
            SendCommand("w");
        }

        public void SetIdleState()
        {
            SendCommand("i");
        }

        public void TryToID()
        {
            SendCommand("a");
        }

        public void Reboot()
        {
            if (!_serialPort.IsOpen)
                SerialOpen();

            _serialPort.DtrEnable = _serialPort.RtsEnable = true;
            Thread.Sleep(300);
            _serialPort.DtrEnable = _serialPort.RtsEnable = false;
            Thread.Sleep(2000);
        }

    }
}
