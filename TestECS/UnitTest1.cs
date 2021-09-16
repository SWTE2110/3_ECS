using ECS.Legacy;
using NUnit.Framework;

namespace TestECS
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void Check_FakeHeater_TurnOn()
        {
            FakeHeater uut = new FakeHeater();

            uut.TurnOn();
            Assert.IsTrue(uut._CheckTurnOn);

        }

        [Test]
        public void Check_FakeHeater_TurnOff()
        {
            FakeHeater uut = new FakeHeater();

            uut.TurnOff();
            
            Assert.IsTrue(uut._CheckTurnOff);

        }
        [Test]
        public void Check_FakeTempSensor()
        {
            FakeHeater uut = new FakeHeater();

            Assert.AreNotEqual(0, uut.GetType());

        }

    }
}