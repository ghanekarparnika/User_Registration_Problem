using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace ExceptionDemo
{
    public class MoodAnalyserFactory
    {

        public static object CreateMoodAnalyserObject(string className, string constructor)
        {

            try
            {

                string pattern = "." + constructor + "$"; // regex for class
                Match result = Regex.Match(className, pattern); // Checking that Class name and constructor name is equal or not             

                if (result.Success)
                {
                    try
                    {
                        Assembly assembly = Assembly.GetExecutingAssembly();
                        Type moodAnalyserType = assembly.GetType(className); // Get the class name type from assembly

                        return Activator.CreateInstance(moodAnalyserType);
                    } catch (MoodAnalyserException e)
                    {
                        throw new MoodAnalyserException(MoodAnalyserException.ExceptionType.NO_SUCH_CLASS, "class not found");
                    }
                }
                else // Constructor name not matched with class name then throw exception like constructor not found
                {
                    throw new MoodAnalyserException(MoodAnalyserException.ExceptionType.CONSTRUCTOR_NOT_FOUND, "Constructor not found");
                }

            }
            catch (MoodAnalyserException e)
            {
                return e.Message;

            }
        
        }


        public static object CreateMoodAnalyserParameterizedObject(string className, string constructor, string message)
        {
            try
            {
                Type type = typeof(MoodAnalyser); // Getting a type of MoodAnalyzer class
                ConstructorInfo constructorInfo = type.GetConstructor(new[] { typeof(string) }); //Getting constructor which hase one parameter of type string
                        return constructorInfo.Invoke(new object[] { message }); //Invoking a object
                       
            }
            catch (MoodAnalyserException e)
            {
                return e.Message;
            }
        }
    }
}
