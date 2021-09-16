using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace ECS.Legacy
{
    public class FakeHeater : IHeater
    {

        private bool _CheckTurnOn = false;
        private bool _CheckTurnOff = false;

        public void TurnOn() { _CheckTurnOn = true; }
        public void TurnOff() { _CheckTurnOff = true; }

        public bool RunSelfTest()
        {
            return true;
        }
    }
}
