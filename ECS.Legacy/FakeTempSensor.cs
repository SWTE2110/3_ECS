using System;
using System.Collections.Generic;
using System.Text;

namespace ECS.Legacy
{
    class FakeTempSensor
    {

        private Random gen = new Random();
        public int GetTemp()
        {

            int _currentGen = gen.Next(-5, 45);

            if (-5 > _currentGen || _currentGen > 45)
                return 0;
            else
                return _currentGen;
        }
        public bool RunSelfTest()
        {
            return true;
        }
    }
}
