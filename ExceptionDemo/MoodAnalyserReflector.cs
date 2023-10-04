using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace ExceptionDemo
{
    public class MoodAnalyserReflector
    {
        public string InvokeMethod(string message, string methodName) // creating a method for invoking method
        {
            try
            {
                Type type = typeof(MoodAnalyser); // Getting type of mood analyzer class
                MethodInfo methodInfo = type.GetMethod(methodName); // Getting method information using reflection

                
                object moodAnalyserObject = MoodAnalyserFactory.CreateMoodAnalyserParameterizedObject("ExceptionDemo.MoodAnalyser", "MoodAnalyser", message);//Creating a parameterized object of Moodanalyser class using reflection
        
                object info = methodInfo.Invoke(moodAnalyserObject, null); //Invoking method using reflection

                return info.ToString(); //returning a mood of user
            }
            catch (NullReferenceException) //If method not found then throw exception
            {
                throw new MoodAnalyserException(MoodAnalyserException.ExceptionType.NO_SUCH_METHOD, "Method not found");
            }
        }


    }
}
