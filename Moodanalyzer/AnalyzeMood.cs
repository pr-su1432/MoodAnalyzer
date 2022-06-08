using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Moodanalyzer
{
    public class AnalyzeMood
    {

        public string mood;
        public AnalyzeMood()
        {

        }
        public AnalyzeMood(string mood)
        {
            this.mood = mood;
        }
        public string getMoodanalyze()
        {
            try
            {
                if (this.mood.Equals(string.Empty))
                    throw new AnalyzerException(AnalyzerException.ExceptionType.EMPTY_MESSAGE, "Mood can not be Empty");
                if (this.mood.Contains("Sad"))
                    return "Sad";
                else
                    return "Happy";
            }
            catch (NullReferenceException)
            {
                throw new AnalyzerException(AnalyzerException.ExceptionType.NULL_MESSAGE, "Mood is null");
            }
        }
    }
}
