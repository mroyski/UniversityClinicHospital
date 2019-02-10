using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace UniversityClinicHospital
{
    public class Doctor : Employee
    {
        public string Specialty { get; set; }
        
        public Doctor(string specialty)
        {
            Specialty = specialty;
            Salary = 90000;
        }

        public override void PaySalary()
        {
            if (Paid == false)
            {
                Paid = true;
                Console.WriteLine($"Doctor {Name} has been paid {Salary}.");
            }
        }

        public override void PrintData()
        {
            Console.WriteLine("Doctor");
            Console.WriteLine($"Name: {Name}");
            Console.WriteLine($"ID#: {Id}");
            Console.WriteLine($"Specialty#: {Specialty}");
            Console.WriteLine($"Salary: {Salary}");
            Console.WriteLine($"Payment Received: {Paid}\n");
        }

        public void DrawBlood(Patient patient)
        {
            patient.BloodLevel -= 5;
            patient.HealthLevel -= 5;
        }
    }
}
