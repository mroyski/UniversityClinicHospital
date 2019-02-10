using System;
using Xunit;
using UniversityClinicHospital;

namespace PatientsTests.Tests
{
    public class PatientsTests
    {
        [Fact]
        public void Patient_Gets_Blood_Drawn()
        {
            Patient jones = new Patient("jones");
            jones.DoctorDrawBlood();
            Assert.Equal(15, jones.BloodLevel);
        }
    }
}
