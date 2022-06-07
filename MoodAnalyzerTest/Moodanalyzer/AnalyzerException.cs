using System.Runtime.Serialization;

namespace Moodanalyzer
{
    [Serializable]
    internal class AnalyzerException : Exception
    {
        public enum ExceptionType
        {
            NULL_MESSAGE, EMPTY_MESSAGE
        }
        public ExceptionType Type;
        public AnalyzerException(ExceptionType type, string message) : base(message)
        {
            this.Type = type;
        }
    }
}