using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FitnessProgramManagementSystem
{
    internal class FitnessProgram
    {

        private string fitnessProgramId {  get; set; }
        private string title { get; set; }
        private string durationduration {  get; set; }
        private string price;{  get; set; }

        public FitnessProgram(string fitnessProgramId, string title, string durationduration, string price)
        {
            this.fitnessProgramId = fitnessProgramId;
            this.title = title;
            this.durationduration = durationduration;
            this.price = price;
        }

        public override string ToString()
        {
            return $"fitnessProgramId: {fitnessProgramId}, Title: {title}, Duration: {durationduration}, Price: {price}";
        }
    }
        
            
    
}
