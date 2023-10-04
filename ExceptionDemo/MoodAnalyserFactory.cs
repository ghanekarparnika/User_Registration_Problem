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
                        Assembly assembly = Assembly.GetExecutingAssembly();
                        Type moodAnalyserType = assembly.GetType(className); // Get the class name type from assembly

                        return Activator.CreateInstance(moodAnalyserType);
                    }
                    catch (MoodAnalyserException e)
                     {
                          return e.Message;
                    }   

        }
    }
}
