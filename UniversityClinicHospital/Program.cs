using System;
using System.Collections.Generic;

namespace UniversityClinicHospital
{
    class Program
    {
        public static Hospital hospital = new Hospital();

        static void Main(string[] args)
        {
            hospital.PrintAllData();
            Console.ReadKey();

            while (true)
            {
                MainMenu();
            }

        }

        static void MainMenu()
        {
            Console.Clear();
            Console.WriteLine("=== Main Menu ===");
            Console.WriteLine("1. Hospital List");
            Console.WriteLine("2. Draw Blood");
            Console.WriteLine("3. Answer Phone");
            Console.WriteLine("4. Sweep Floor");
            Console.WriteLine("5. Pay Employee");

            string choice = Console.ReadLine();
            switch (choice)
            {
                case "1":
                    hospital.PrintAllData();
                    break;
                case "2":
                    break;
                case "3":
                    break;
                case "4":
                    break;
                case "5":
                    break;
                default:
                    MainMenu();
                    break;

            }

        }

        static void PickDoctorNurse()
        {
            foreach (var Patient in Patients)
            {
                patient.PrintPatientData();
            }
        }

    }
}
