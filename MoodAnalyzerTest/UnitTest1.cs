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
    }
}
