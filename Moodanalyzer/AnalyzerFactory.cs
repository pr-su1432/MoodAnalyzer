using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Moodanalyzer
{
    public class AnalyzerFactory 
    {
      

        public static object MoodAnalyzer(string ClassName,string ConstructorName)
        {
            string pattern =  @"." + ConstructorName + "$";
            Match result = Regex.Match(ClassName, pattern);

            if (result.Success)
            {
                try
                {
                    Assembly executing = Assembly.GetExecutingAssembly();
                    Type AnalyzeMoodType = executing.GetType(ClassName);
                    return Activator.CreateInstance(AnalyzeMoodType);
                }
                catch (ArgumentNullException)
                {
                    throw new AnalyzerException(AnalyzerException.ExceptionType.NO_SUCH_CLASS, "Class not found");
                }
            }
            else
            {
                throw new AnalyzerException(AnalyzerException.ExceptionType.NO_SUCH_METHOD, "Constructor is not found");
            }
        }
        
    }
}
