using System;
using System.Collections.Generic;
using System.Text;

namespace UniversityClinicHospital
{
    public abstract class Employee
    {
        public string Name { get; set; }
        public int Id { get; set; }
        public int Salary { get; set; }
        public bool Paid { get; set; }

        public Employee()
        {
            Paid = false;
        }

        public abstract void PaySalary();

        public abstract void PrintData();

    }
}
