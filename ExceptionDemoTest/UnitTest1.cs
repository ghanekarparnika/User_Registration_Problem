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

        [TestMethod]
        public void GivenNullMoodShouldThrowInvalidMood()
        {
            try
            {
                //Arrange
                string expected = "Invalid Mood";
                string message = null;
                MoodAnalyser moodAnalyser = new MoodAnalyser(message);
                //Act
                string actual = moodAnalyser.analyseMood();
                
               
            }catch(MoodAnalyserException e)
            {
                //Assert
                Assert.AreEqual("Invalid Mood", e.Message);
            }

        }


        [TestMethod]
        public void GivenEmptyMoodShouldThrowInvalidMood()
        {
            try
            {
                //Arrange
                string expected = "Invalid Mood";
                string message = " ";
                MoodAnalyser moodAnalyser = new MoodAnalyser(message);
                //Act
                string actual = moodAnalyser.analyseMood();


            }
            catch (MoodAnalyserException e)
            {
                //Assert
                Assert.AreEqual("Invalid Mood", e.Message);
            }

        }

        [TestMethod]
        public void GivenClassNameShoulReturnObject()
        {
            object expected = new MoodAnalyser();
            object actual = MoodAnalyserFactory.CreateMoodAnalyserObject("ExceptionDemo.MoodAnalyser", "MoodAnalyser");
            expected.Equals(actual);
        }

        //passing wrong class neme
        [TestMethod]
        public void GivenImproperClassNameShoulReturnException()
        {
            object expected = new MoodAnalyser();
            object actual = MoodAnalyserFactory.CreateMoodAnalyserObject("ExceptionDemo.MooodAnalyser", "MoodAnalyser");
            expected.Equals(actual);
        }




        //TC4.3-passing wrong constructor name
        [TestMethod]
        public void GivenImproperConstructorNameShoulReturnException()
        {
            object expected = new MoodAnalyser();
            object actual = MoodAnalyserFactory.CreateMoodAnalyserObject("ExceptionDemo.MooodAnalyser", "MoodAnalyser");
            expected.Equals(actual);
        }

        //UC5-Given MoodAnalyser Class Name Should Return MoodAnalyser object with parameter
        [TestMethod]
        public void GivenClassNameShouldReturnParameterizedObject()
        {
            string message = "I am in happy mood";
            object expected = new MoodAnalyser(message);
            object actual = MoodAnalyserFactory.CreateMoodAnalyserParameterizedObject("ExceptionDemo.MoodAnalyser", "MoodAnalyser", message);
            expected.Equals(actual);
        }
    }
}