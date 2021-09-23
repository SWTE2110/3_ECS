using System;
using System.Collections.Generic;
using System.Text;
using NUnit.Framework;
using ECS.Legacy;

namespace ECS.Test
{
    public class TempSensorTest
    {
        private TempSensor uut;

        [SetUp]
        public void Setup()
        {
            uut = new TempSensor();
        }
        [Test]
        public void GetTemp_Test()
        {
            bool res = true;
            int i = 0;
            int temp;
            while(res && i<1000)
            {
                temp = uut.GetTemp();
                res = (temp >= -5 && temp <= 45);
                i++;
            }

            Assert.AreEqual(true, res);
        }

        [Test]
        public void RunSelfTest_Test()
        {
            bool res = uut.RunSelfTest();

            Assert.AreEqual(true, res);
        }
    }
}
