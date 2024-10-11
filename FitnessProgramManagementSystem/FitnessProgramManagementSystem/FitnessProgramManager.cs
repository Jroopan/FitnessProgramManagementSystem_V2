using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FitnessProgramManagementSystem
{
    internal class FitnessProgramManager
    {
       

        public List<FitnessProgram> FitnessPrograms { get; set; }

        public FitnessProgramManager()
        {
            FitnessPrograms =new List<FitnessProgram>();

        }
        public void CreateFitnessProgram(string fitnessProgramId, string title, string durationduration, string price)

        {
            FitnessProgram program= new FitnessProgram(fitnessProgramId, title, durationduration, price);
            FitnessPrograms.Add(program);
            Console.WriteLine("program create succesfully");

        }
        public void ReadFitnessPrograms()
        {
            if (FitnessPrograms.Count == 0)
            {
                Console.WriteLine("No programs available");
            }
            else
            {
                Console.WriteLine("Programs lists: ");
                foreach (var program in FitnessPrograms)
                {
                    Console.WriteLine(program.ToString());
                }
            }
        }

        public void UpdateFitnessProgram(string id, string title, string duration, decimal price)
        {
            var findedProgram = FitnessPrograms.Find(p => p.fitnessProgramId == id);
            if (findedProgram != null)
            {
                findedProgram.title = title;
                findedProgram.Duration = duration;
                findedProgram.Price = price;
                Console.WriteLine("Program updated successfully");
            }
            else
            {
                Console.WriteLine("No program found");
            }
        }

        public void DeleteFitnessProgram(int id)
        {
            var findedProgram = FitnessPrograms.Find(p => p.fitnessProgramId == id);
            if (findedProgram != null)
            {
                FitnessPrograms.Remove(findedProgram);
                Console.WriteLine("Program deleted successfully");


            }
            else
            {
                Console.WriteLine("No program found");
            }

        }

    }
    public decimal FitnessProgramRentaprice()
    {
        decimal price;
        while (true)
        {
            Console.WriteLine("Enter the FitnessProgram’s Rental price: ");
            if (decimal.TryParse(Console.ReadLine(), out price) && price > 0)
            {
                return price;
            }
            Console.WriteLine("Invalid price!! Please enter correct value");
        }
    }
}

