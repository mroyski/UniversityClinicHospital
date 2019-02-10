using System;
using System.Collections.Generic;
using System.Text;

namespace UniversityClinicHospital
{
    public class Janitor : Employee
    {
        public bool Sweeping { get; set; }

        public Janitor()
        {
            Sweeping = false;
            Salary = 40000;
        }

        public override void PaySalary()
        {
            if (Paid == false)
            {
                Paid = true;
                Console.WriteLine($"Janitor {Name} has been paid.");
            }
        }

        public override void PrintData()
        {
            Console.WriteLine("Janitor");
            Console.WriteLine($"Name: {Name}");
            Console.WriteLine($"ID#: {Id}");
            Console.WriteLine($"Sweeping: {Sweeping}");
            Console.WriteLine($"Salary: {Salary}");
            Console.WriteLine($"Payment Received: {Paid}\n");
        }

        public void SweepFloor()
        {
            if (Sweeping == false)
            {
                Sweeping = true;
                Console.WriteLine($"{Name} grabs a broom and gets to work.");
            }
            else
            {
                Sweeping = false;
                Console.WriteLine($"{Name} takes a break from sweeping.");
            }
        }
    }
}
