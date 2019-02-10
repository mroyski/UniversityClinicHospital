using System;
using System.Collections.Generic;
using System.Text;

namespace UniversityClinicHospital
{
    public class Receptionist : Employee
    {
        public bool OnPhone { get; set; }

        public Receptionist()
        {
            OnPhone = false;
            Salary = 45000;
        }

        public override void PaySalary()
        {
            if (Paid == false)
            {
                Paid = true;
                Console.WriteLine($"Receptionist {Name} has been paid.");
            }
        }

        public override void PrintData()
        {
            Console.WriteLine("Receptionist");
            Console.WriteLine($"Name: {Name}");
            Console.WriteLine($"ID#: {Id}");
            Console.WriteLine($"On Call: {OnPhone}");
            Console.WriteLine($"Salary: {Salary}");
            Console.WriteLine($"Payment Received: {Paid}\n");
        }

        public void AnswerPhone()
        {
            if (OnPhone == false)
            {
                OnPhone = true;
                Console.WriteLine($"{Name} answered the phone.");
            }
            else
            {
                OnPhone = false;
                Console.WriteLine($"{Name} is already busy, but hangs up to answer you.");
            }
        }
    }
}
