using System;
using UniversityClinicHospital;
using Xunit;

namespace DoctorTests
{
    public class DoctorTests
    {
        [Fact]
        public void Constructor_Sets_Specialty()
        {
            var joey = new Doctor("Heart");

            Assert.Equal("Heart", joey.Specialty);
        }

        [Fact]
        public void Constructor_Sets_Name()
        {
            var joey = new Doctor("Heart");

            joey.Name = "Indiana Jones";

            Assert.Equal("Indiana Jones", joey.Name);
        }

        [Fact]
        public void Doctor_Gets_Paid()
        {
            var joey = new Doctor("Heart");

            joey.PaySalary();

            Assert.True(joey.Paid);
        }

        [Fact]
        public void Doctor_Draws_Blood()
        {
            var joey = new Doctor("Heart");
            var sam = new Patient("Sam");

        }
    }
}
