using System;
using System.Collections.Generic;
using System.Text;
using UniversityClinicHospital;

namespace UniversityClinicHospital
{
    public class Patient
    {
        public string Name { get; set; }
        public int BloodLevel { get; private set; }
        public int HealthLevel { get; private set; }

        public Patient()
        {
            BloodLevel = 20;
            HealthLevel = 10;
        }

        public void PrintPatientData()
        {
            Console.WriteLine($"Name: {Name}");
            Console.WriteLine($"Blood: {BloodLevel}");
            Console.WriteLine($"Health: {HealthLevel}\n");
        }

        public void DoctorDrawBlood(Doctor doctor)
        {
            BloodLevel -= 5;
            HealthLevel -= 5;
            Console.WriteLine($"{Name}'s blood was drawn by a doctor.");
            Console.WriteLine($"{Name}'s Blood Level is now {BloodLevel}\n");
            Console.WriteLine($"{Name}'s Health Level is now {HealthLevel}\n");

        }

        public void NurseDrawBlood(Nurse nurse)
        {
            BloodLevel -= 2;
            HealthLevel -= 2;
            Console.WriteLine($"{Name}'s blood was drawn by a nurse.");
            Console.WriteLine($"{Name}'s Blood Level is now {BloodLevel}\n");
            Console.WriteLine($"{Name}'s Health Level is now {HealthLevel}\n");
        }

    }
}
