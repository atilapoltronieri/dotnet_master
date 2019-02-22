using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Xunit;

namespace AMcom.Teste.Service.Tests
{
    public class UbsServiceTest
    {
        [Fact]
        public void ReturnFirstFiveNearestsUbs()
        {
            Assert.Equal(5, UbsService.GetNearestUbs(-19.48594331741306, -5.8575725555409).Count());
        }

        [Fact]
        public void ReturnFirstFiveNearestsUbsLoop()
        {
            double latitude = -50;
            double longetude = -50;
            for (int i = 0; i < 100; i++)
            {
                Assert.Equal(5, UbsService.GetNearestUbs(latitude, longetude).Count());
                latitude += 1;
                longetude += 1;
            }
        }


        [Fact]
        public void AvaliationOverDistance()
        {
            Assert.NotEqual("USF ENFERMEIRO PEDRO JACINTO AREA 09", UbsService.GetNearestUbs(-9.48594331741306, -35.8575725555409).First().Nome);
        }

        [Fact]
        public void DistanceOverAvaliationShallFail()
        {
            Assert.Equal("USF ENFERMEIRO PEDRO JACINTO AREA 09", UbsService.GetNearestUbs(-9.48594331741306, -35.8575725555409).First().Nome);
        }
    }
}