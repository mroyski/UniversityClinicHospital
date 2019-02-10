using System;
using System.Collections.Generic;
using System.Text;

namespace UniversityClinicHospital
{
    public class Nurse : Employee
    {
        public int NumOfPatients { get; set; }

        public Nurse()
        {
            Salary = 50000;
        }

        public override void PaySalary()
        {
            if (Paid == false)
            {
                Paid = true;
                Console.WriteLine($"Nurse {Name} has been paid {Salary}.");
            }
        }

        public override void PrintData()
        {
            Console.WriteLine("Nurse");
            Console.WriteLine($"Name: {Name}");
            Console.WriteLine($"ID#: {Id}");
            Console.WriteLine($"#Patients: {NumOfPatients}");
            Console.WriteLine($"Salary: {Salary}");
            Console.WriteLine($"Payment Received: {Paid}\n");
        }

        public void DrawBlood(Patient patient)
        {
            patient.BloodLevel -= 2;
            patient.HealthLevel -= 2;
        }

    }
}
