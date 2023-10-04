using ExceptionDemo;
using Newtonsoft.Json.Linq;

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

        //UC5.1-Given MoodAnalyser Class Name Should Return MoodAnalyser object with parameter
        [TestMethod]
        public void GivenClassNameShouldReturnParameterizedObject()
        {
            string message = "I am in happy mood";
            object expected = new MoodAnalyser(message);
            object actual = MoodAnalyserFactory.CreateMoodAnalyserParameterizedObject("ExceptionDemo.MoodAnalyser", "MoodAnalyser", message);
            expected.Equals(actual);
        }

        //TC5.2-Given Class Name When  Improper Should Throw MoodAnalysisException

                [TestMethod]
        public void GivenInvalidClassNameWithMessageThrowException()
        {
            try
            {
                string message = "I am in happy mood";
                object expected = new MoodAnalyser(message);
                object actual = MoodAnalyserFactory.CreateMoodAnalyserParameterizedObject("ExceptionDemo.Mood", "Mood", message);
            }
            catch (MoodAnalyserException ex)
            {
                Assert.AreEqual("Class not found", ex.Message);
            }
        }

        //TC5.3-Given Class When Constructor Not Proper Should Throw MoodAnalysisException

        [TestMethod]
        public void GivenInvalidConstructorWithMessageThrowException()
        {
            try
            {
                string message = "I am in happy mood";
                object expected = new MoodAnalyser(message);
                object actual = MoodAnalyserFactory.CreateMoodAnalyserParameterizedObject("ExceptionDemo.MoodAnalyser", "Mood", message);
            }
            catch (MoodAnalyserException ex)
            {
                Assert.AreEqual("Constructor not found", ex.Message);
            }
        }

        //TC6.1
        [TestMethod]
        public void GivenMethodNameWithMessageReturnMood()
        {
            string message = "I am in happy mood";
            string expected = "HAPPY";
            string actual = "";
            try
            {
                MoodAnalyserReflector moodAnalyserReflector = new MoodAnalyserReflector();
                actual = moodAnalyserReflector.InvokeMethod(message, "analyseMood");
            }
            catch (MoodAnalyserException ex)
            {
                Assert.AreEqual("Method not found", ex.Message);
            }
            Assert.AreEqual(expected, actual);
        }

      //  TC6.2
        [TestMethod]
        public void GivenInvalidMethodNameWithMessageThrowException()
        {
            string message = "I am in happy mood";
            string expected = "HAPPY";
            string actual = "";
            try
            {
                MoodAnalyserReflector moodAnalyzerReflector = new MoodAnalyserReflector();
                actual = moodAnalyzerReflector.InvokeMethod(message, "Mood");
                Assert.AreEqual(expected, actual);
            }
            catch (MoodAnalyserException ex)
            {
                Assert.AreEqual("Method not found", ex.Message);
            }
        }


    }
}