using System;
using System.IO;
using System.Security.Cryptography;
using ECS.Legacy;
using NUnit.Framework;

namespace ECS.Test
{
    public class HeaterTest
    {
        private Heater uut;
        [SetUp]
        public void Setup()

        {
            uut = new Heater();
        }

        [Test]
        public void TurnOn_Test()
        {
            StringWriter sw = new StringWriter();

            Console.SetOut(sw);

            uut.TurnOn();
            string expected = string.Format("Heater is on{0}", Environment.NewLine);
            Assert.AreEqual(expected,sw.ToString());

        }
        [Test]
        public void TurnOff_Test()
        {
            StringWriter sw = new StringWriter();

            Console.SetOut(sw);

            uut.TurnOff();
            string expected = string.Format("Heater is off{0}", Environment.NewLine);
            Assert.AreEqual(expected, sw.ToString());
        }
        [Test]
        public void RunSelfTest_Test()
        {
            var res = uut.RunSelfTest();
            Assert.AreEqual(true, res);
        }
    }
}