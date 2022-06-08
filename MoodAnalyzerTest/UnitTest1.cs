using Moodanalyzer;

namespace MoodAnalyzerTest
{
    public class Tests
    {
        

        [Test]
        public void GivenMood_AnalyzeMood_ReturnMoodSad()
        {
            string message = "I am in Sad mood";
            Moodanalyzer.AnalyzeMood mood = new Moodanalyzer.AnalyzeMood(message);
            string actualResult = mood.getMoodanalyze();
            Assert.AreEqual("Sad", actualResult);
           
        }
        [Test]
        public void GivenMoodAny_AnalyzeMood_ReturnHappyMood()
        {
            string message = "I am in Happy Mood";
            Moodanalyzer.AnalyzeMood mood = new Moodanalyzer.AnalyzeMood(message);
            string actualResult = mood.getMoodanalyze();
            Assert.AreEqual("Happy", actualResult);
        }
        [Test]
        public void GivenNull_AnalyzeMood_ReturnHappyMood()
        {
            string message = "Null";
            Moodanalyzer.AnalyzeMood mood = new Moodanalyzer.AnalyzeMood(message);
            string actualResult = mood.getMoodanalyze();
            Assert.AreEqual("Happy", actualResult);
        }
        [Test]
        public void GivenEmpty_AnalyzeMood_EmptyException_ReturnEmptyMood()
        {
            try
            {
                string message = "";
                Moodanalyzer.AnalyzeMood mood = new Moodanalyzer.AnalyzeMood(message);
                string actualResult = mood.getMoodanalyze();
            }
            catch (Moodanalyzer.AnalyzerException exe)
            {
                Assert.AreEqual("Mood can not be Empty", exe.Message);
            }

        }
        [Test]
        public void GivenMoodAnalyzeClassName_MoodClassName_ReturnClassnameObject()
        {
            object expected = new AnalyzeMood();
           
    
            object obj = AnalyzerFactory.MoodAnalyzer("Moodanalyzer.AnalyzeMood", "AnalyzeMood");
            expected.Equals(obj);

        }
        [Test]
       
        public void GivenMoodAnalyseClassName_ShouldreturnClassNotFound()
        {
            try
            {
                string message = null;
                object expected = new AnalyzeMood(message);
                object actual = AnalyzerFactory.MoodAnalyzer("Moodanalyzer.AnalyeMood", "AnalyzeMood");
                expected.Equals(actual);
            }
            catch (Moodanalyzer.AnalyzerException ex)
            {
                Assert.AreEqual("Class not found", ex.Message);
            }
        }
        [Test]
        public void GivenMoodAnalyseClassName_ShouldreturnConstructorNotFound()
        {
            try
            {
                string message = null;
                object expected = new AnalyzeMood(message);
                object actual = AnalyzerFactory.MoodAnalyzer("Moodanalyzer.AnalyzeMood", "AnalyzeMod");
                expected.Equals(actual);
            }
            catch (Moodanalyzer.AnalyzerException exp)
            {
                Assert.AreEqual("Constructor is not found", exp.Message);
            }
        }
    }
}