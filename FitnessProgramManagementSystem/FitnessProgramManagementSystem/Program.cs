using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FitnessProgramManagementSystem
{
    internal class Program
    {
        static void Main(string[] args)
        {
            FitnessProgramManager manager1 = new FitnessProgramManager();
            bool exit = false;

            while (!exit)
            {
                Console.Clear();
                Console.WriteLine("\nFitnessProgram Management System:");
                Console.WriteLine(" 1. Add a FitnessProgram");
                Console.WriteLine(" 2. View All FitnessPrograms");
                Console.WriteLine(" 3. Update a FitnessProgram");
                Console.WriteLine(" 4. Delete a FitnessProgram");
                Console.WriteLine(" 5. Exit");
                Console.Write(" Choose an option:");
                string option = Console.ReadLine();

                switch (option)
                {
                    case "1":
                        Console.Clear();
                        CreateFitnessProgram(manager1);
                        break;

                    case "2":
                        Console.Clear();
                        manager1.ReadFitnessPrograms();
                        break;

                    case "3":
                        Console.Clear();
                        UpdateFitnessProgram(manager1);
                        break;

                    case "4":
                        Console.Clear();
                        DeleteFitnessProgram(manager1);
                        break;
                    case "5":
                        Console.Clear();
                        exit = true;
                        break;
                    default:
                        Console.WriteLine("Please select valid choice");
                        break;
                }

                if (!exit)
                {
                    Console.WriteLine("\nPress enter to continue...");
                    Console.ReadLine();
                }
            }

        }

       
    }
}
