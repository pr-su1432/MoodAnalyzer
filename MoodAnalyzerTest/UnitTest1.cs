namespace MoodAnalyzerTest
{
    public class Tests
    {
        private string message;

        [Test]
        public void GivenMood_AnalyzeMood_ReturnMoodSad()
        {
            string message = "I am in Sad mood";
            Moodanalyzer.AnalyzeMood mood = new Moodanalyzer.AnalyzeMood(message);
            string actualResult = mood.getMoodanalyze("I am in Sad mood");
            Assert.AreEqual("Sad", actualResult);
           
        }
        [Test]
        public void GivenMoodAny_AnalyzeMood_ReturnHappyMood()
        {
            string message = "I am in Happy Mood";
            Moodanalyzer.AnalyzeMood mood = new Moodanalyzer.AnalyzeMood(message);
            string actualResult = mood.getMoodanalyze("I am in Any mood");
            Assert.AreEqual("Happy", actualResult);
        }
    }
}