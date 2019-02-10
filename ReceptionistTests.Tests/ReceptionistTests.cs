using System;
using UniversityClinicHospital;
using Xunit;


namespace ReceptionistTests.Tests
{
    public class ReceptionistTests
    {
        [Fact]
        public void Receptionist_Gets_Paid()
        {
            var joey = new Receptionist();

            joey.PaySalary();

            Assert.True(joey.Paid);
        }

        [Fact]
        public void Receptionst_Answers_Phone()
        {
            var joey = new Receptionist();

            joey.AnswerPhone();

            Assert.True(joey.OnPhone);
        }
    }
}
