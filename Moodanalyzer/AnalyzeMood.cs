using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Moodanalyzer
{
    public class AnalyzeMood
    {
       private string mood;
        public AnalyzeMood(string mood)
        {
            this.mood = mood;
        }
        public string getMoodanalyze()
        {
            if (this.mood.Contains("Sad"))
            {

                return "Sad";
            }
            else
            { 
                return "Happy";
            }
        }
    }
}
