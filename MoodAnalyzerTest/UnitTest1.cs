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
    }
}