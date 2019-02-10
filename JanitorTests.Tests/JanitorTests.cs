using System;
using UniversityClinicHospital;
using Xunit;

namespace JanitorTests.Tests
{
    public class JanitorTests
    {
        [Fact]
        public void Janitor_Gets_Paid()
        {
            var joey = new Janitor();

            joey.PaySalary();

            Assert.True(joey.Paid);
        }

        [Fact]
        public void Janitor_Sweeps_Floor()
        {
            var joey = new Janitor();

            joey.SweepFloor();

            Assert.True(joey.Sweeping);
        }
    }
}
