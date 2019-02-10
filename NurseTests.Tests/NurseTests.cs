using System;
using UniversityClinicHospital;
using Xunit;

namespace NurseTests.Tests
{
    public class NurseTests
    {
        [Fact]
        public void Nurse_Gets_Paid()
        {
            var joey = new Nurse();

            joey.PaySalary();

            Assert.True(joey.Paid);
        }
    }
}
