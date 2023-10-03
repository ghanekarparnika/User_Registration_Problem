using ExceptionDemo;

namespace ExceptionDemoTest
{
    [TestClass]
    public class UnitTest1
    {
        //tc1.1
        [TestMethod]
        public void GivenSadMoodreturnSAD()
        {
            //Arrange
            string expected = "SAD";
            string message = "I am in sad mood";
            MoodAnalyser moodAnalyser = new MoodAnalyser(message);
            //Act
            string actual = moodAnalyser.analyseMood();
            //Assert
            Assert.AreEqual(expected, actual);
        }
        //tc1.2
        [TestMethod]
        public void GivenSadMoodreturnHAPPY()
        {
            //Arrange
            string expected = "HAPPY";
            string message = "I am in any mood";
            MoodAnalyser moodAnalyser = new MoodAnalyser(message);
            //Act
            string actual = moodAnalyser.analyseMood();
            //Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void GivenNullMoodreturnHAPPY()
        {
            //Arrange
            string expected = "HAPPY";
            string message = null;
            MoodAnalyser moodAnalyser = new MoodAnalyser(message);
            //Act
            string actual = moodAnalyser.analyseMood();
            //Assert
            Assert.AreEqual(expected, actual);

        }
    }
}