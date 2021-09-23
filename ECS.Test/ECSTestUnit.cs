using System;
using System.Collections.Generic;
using System.Text;
using NUnit.Framework;
using ECS.Legacy;
using NSubstitute;

namespace ECS.Test
{
    public class ECSTestUnit
    {
        private Legacy.ECS uut;
        private IHeater _heaterSub;
        private ITempSensor _tempSub;

        [SetUp]
        public void Setup()
        {
            _heaterSub = Substitute.For<IHeater>();
            _tempSub = Substitute.For<ITempSensor>();
            uut = new Legacy.ECS(30, _tempSub, _heaterSub);

        }

        [Test]
        public void HeaterTurnsOff()
        {

            _tempSub.GetTemp().Returns(28);
            uut.Regulate();

            _heaterSub.Received().TurnOff();

          
        }

        [Test]
        public void HeaterTurnsOn()
        {
            _tempSub.GetTemp().Returns(31);
            uut.Regulate();

            _heaterSub.Received().TurnOn();
        }




    }
}
