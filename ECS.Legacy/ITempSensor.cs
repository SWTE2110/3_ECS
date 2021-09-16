using System;
using System.Collections.Generic;
using System.Text;

namespace ECS.Legacy
{
    public interface ITempSensor
    {
        public int GetTemp()
        {
            return 0;
        }

        public bool RunSelfTest()
        {
            return true;
        }

    }
}
