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
        public static object createMoodAnalyzerParameter(string ClassName, string ConstructorName, string message)
        {
            Type type = typeof(AnalyzeMood);
            if (type.Name.Equals(ClassName) || type.FullName.Equals(ClassName))
            {
                if (type.Name.Equals(ConstructorName))
                {
                    ConstructorInfo ctor = type.GetConstructor(new[] { typeof(string) });
                    object instance = ctor.Invoke(new object[] { message });
                    return instance;
                }
                else
                {
                    throw new AnalyzerException(AnalyzerException.ExceptionType.NO_SUCH_METHOD, "Constructor is not found");
                }
            }
            else
            {
                throw new AnalyzerException(AnalyzerException.ExceptionType.NO_SUCH_CLASS, "Class not found");
            }
        }
        public static object InvokeMoodAnalyser(string mood, string methodName)
        {
            try
            {
                Type type = Type.GetType("Moodanalyzer.AnalyzeMood");
                object moodAnalyse = AnalyzerFactory.createMoodAnalyzerParameter("Moodanalyzer.AnalyzeMood", "AnalyzeMood", "Happy");
                MethodInfo method = type.GetMethod(methodName);
                object chkmood = method.Invoke(moodAnalyse, null);
                return chkmood.ToString();
            }
            catch (NullReferenceException)
            {
                throw new AnalyzerException(AnalyzerException.ExceptionType.NO_SUCH_METHOD, "Method is Not Found");
            }

        }
        public static object SetField(string mood, string fieldName)
        {
            try
            {
                AnalyzeMood moodAnalyser = new AnalyzeMood();
                Type type = typeof(AnalyzeMood);
                FieldInfo field = type.GetField(fieldName, BindingFlags.Public | BindingFlags.Instance);
                if (mood == null)
                {
                    throw new AnalyzerException(AnalyzerException.ExceptionType.NULL_MESSAGE, "Mood Should not be null");
                }
                field.SetValue(moodAnalyser, mood);
                return moodAnalyser.mood;
            }
            catch (NullReferenceException)
            {
                throw new AnalyzerException(AnalyzerException.ExceptionType.NO_SUCH_FIELD, "Field Not Found");
            }
        }
    }
}
