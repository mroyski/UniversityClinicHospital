using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace UniversityClinicHospital
{
    public class Hospital
    {
        public List<Employee> Employees { get; set; }
        public List<Patient> Patients { get; set; }

        public Hospital()
        {
            Employees = new List<Employee>();
            Patients = new List<Patient>();

            Doctor joey = new Doctor("Heart");
            AddEmployee(joey);
            joey.Name = "Joey";
            joey.Id = 1234;

            Nurse kate = new Nurse();
            AddEmployee(kate);
            kate.Name = "Kate";
            kate.Id = 4836;

            Receptionist jane = new Receptionist();
            AddEmployee(jane);
            jane.Name = "Jane";
            jane.Id = 9548;

            Janitor bertha = new Janitor();
            AddEmployee(bertha);
            bertha.Name = "Bertha";
            bertha.Id = 4372;

            Patient sam = new Patient();
            AddPatient(sam);
            sam.Name = "Sam";
        }

        public void AddEmployee(Employee employees)
        {
            Employees.Add(employees);
        }

        public void AddPatient(Patient patient)
        {
            Patients.Add(patient);
        }

        public void PrintAllData()
        {
            foreach (var Employee in Employees)
            {
                Console.WriteLine("=== Employee ===");
                Employee.PrintData();
            }

            foreach (var Patient in Patients)
            {
                Console.WriteLine("\n=== Patient ===");
                Patient.PrintPatientData();
            }
            Console.ReadKey();
        }

    }
}
