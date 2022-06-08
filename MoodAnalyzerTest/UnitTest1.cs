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

        public void GivenMoodAnalyseClassName_MoodClassName_ReturnClassNotFound()
        {
            try
            {
                string message = null;
                object expected = new AnalyzeMood(message);
                object actual = AnalyzerFactory.MoodAnalyzer("Moodanalyzer.AnalyzeMood", "Moodanalyzer.AnalyzeMood");
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
        [Test]
        public void GivenMoodParameter_MoodParameterConstructor_ReturnParameterConstructor()
        {
            object expexted = new AnalyzeMood("HAPPY");
            object value = AnalyzerFactory.createMoodAnalyzerParameter("Moodanalyzer.AnalyzeMood", "AnalyzeMood", "HAPPY");
            expexted.Equals(value);
        }
        [Test]
        public void GivenInvalidClassNameAndValidPerameterizedConstructor_ReturnNoSuchConstructor()
        {
            try
            {
                object expected = new Moodanalyzer.AnalyzeMood("HAPPY");
                object actual = Moodanalyzer.AnalyzerFactory.createMoodAnalyzerParameter("AnalyzeMood", "AnalyzeMd", "HAPPY");
                expected.Equals(actual);
            }
            catch (Exception e)
            {
                Assert.AreEqual("Constructor is not found", e.Message);
            }

        }
        [Test]
        public void GivenInvalidPerameterizedConstructor_ReturnClassNotFound()
        {
            try
            {
                object expected = new Moodanalyzer.AnalyzeMood("HAPPY");
                object actual = Moodanalyzer.AnalyzerFactory.createMoodAnalyzerParameter("AnaMood", "AnalyzeMood", "HAPPY");
                expected.Equals(actual);
            }
            catch (Exception e)
            {
                Assert.AreEqual("Class not found", e.Message);
            }

        }
        [Test]
        public void GivenHappyIsInput_ShouldReturnHappy_UsinReflection()
        {
            object expected = "Happy";
            object actual = Moodanalyzer.AnalyzerFactory.InvokeMoodAnalyser("Happy", "getMoodanalyze");
            Assert.AreEqual(expected, actual);
        }
        [Test]
        public void GivenImproperMethodName_NoSuchMethodException_UsingReflector()
        {
            try
            {
                object expected = "HAPPY";
                object actual = Moodanalyzer.AnalyzerFactory.InvokeMoodAnalyser("HAPPY", "getMoodanalyze");
                expected.Equals(actual);
            }
            catch (Moodanalyzer.AnalyzerException exe)
            {
                Assert.AreEqual("Constructor is not found", exe.Message);
            }

        }
        [Test]
        public void GivenHappyMoodDynamivRefactorReturnHappy()
        {
            object result = Moodanalyzer.AnalyzerFactory.SetField("Happy", "mood");
            Assert.AreEqual("Happy", result);
        }

    }
}