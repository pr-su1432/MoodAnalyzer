namespace MoodAnalyzerTest
{
    public class Tests
    {
    

        [Test]
        public void GivenMood_AnalyzeMood_ReturnMoodSad()
        {
            Moodanalyzer.AnalyzeMood mood = new Moodanalyzer.AnalyzeMood();
            string actualResult = mood.getMoodanalyze("I am in Sad mood");
            Assert.AreEqual("Sad", actualResult);
           
        }
        [Test]
        public void GivenMoodAny_AnalyzeMood_ReturnHappyMood()
        {
            Moodanalyzer.AnalyzeMood mood = new Moodanalyzer.AnalyzeMood();
            string actualResult = mood.getMoodanalyze("I am in Any mood");
            Assert.AreEqual("Happy", actualResult);
        }
    }
}