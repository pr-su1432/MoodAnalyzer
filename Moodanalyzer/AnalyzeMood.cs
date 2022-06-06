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
        public AnalyzeMood(string message)
        {
            this.mood = message;
        }
        public string getMoodanalyze()
        {
            try
            {
                if (this.mood.Contains("Sad"))
                    return "Sad";
                else
                    return "Happy";
            }
            catch (NullReferenceException)
            {
                return "Happy";
            }
        }
    }
}



