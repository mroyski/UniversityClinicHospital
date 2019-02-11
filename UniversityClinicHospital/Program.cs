using System;
using System.Collections.Generic;

namespace UniversityClinicHospital
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                MainMenu();
            }
        }

        static void MainMenu()
        {
            List<Employee> employees = new List<Employee>();
            Doctor joey = new Doctor("Heart");
            employees.Add(joey);
            joey.Name = "Joey";
            joey.Id = 1234;

            Nurse kate = new Nurse();
            employees.Add(kate);
            kate.Name = "Kate";
            kate.Id = 4836;

            Receptionist jane = new Receptionist();
            employees.Add(jane);
            jane.Name = "Jane";
            jane.Id = 9548;

            Janitor bertha = new Janitor();
            employees.Add(bertha);
            bertha.Name = "Bertha";
            bertha.Id = 4372;

            Patient newPatient = new Patient("Sam");

            bool run = true;
            while (run)
            {
                Console.Clear();
                Console.WriteLine("=== Main Menu ===");
                Console.WriteLine("1. Hospital List");
                Console.WriteLine("2. Draw Blood");
                Console.WriteLine("3. Answer Phone");
                Console.WriteLine("4. Sweep Floor");
                Console.WriteLine("5. Pay Employees");
                Console.WriteLine("0. EXIT");

                string choice = Console.ReadLine();
                switch (choice)
                {
                    case "1":
                        Console.Clear();
                        joey.PrintData();
                        kate.PrintData();
                        jane.PrintData();
                        bertha.PrintData();
                        Console.ReadKey();
                        break;
                    case "2":
                        Console.Clear();
                        Console.WriteLine("1. By Doctor\n2. By Nurse");
                        string pick = Console.ReadLine();
                        if (pick == "1")
                        {
                            newPatient.DoctorDrawBlood();
                            Console.ReadKey();
                        }
                        else if (pick == "2")
                        {
                            newPatient.NurseDrawBlood();
                            Console.ReadKey();
                        }
                        break;
                    case "3":
                        Console.Clear();
                        jane.AnswerPhone();
                        Console.ReadKey();
                        break;
                    case "4":
                        Console.Clear();
                        bertha.SweepFloor();
                        Console.ReadKey();
                        break;
                    case "5":
                        foreach (var Employee in employees)
                        {
                            Console.Clear();
                            Console.WriteLine($"Pay {Employee.Name}?");
                            Console.WriteLine("y for yes   n for no");
                            string payment = Console.ReadLine();
                            if (payment == "y")
                            {
                                if (Employee.Paid == false)
                                {
                                    Employee.PaySalary();
                                }
                                else
                                {
                                    Console.WriteLine($"{Employee.Name} has already been paid.");
                                    Console.ReadKey();
                                }
                            }
                        }
                        break;
                    case "0":
                        Environment.Exit(0);
                        break;
                    default:
                        MainMenu();
                        break;
                }
            }
        }

    }
}
