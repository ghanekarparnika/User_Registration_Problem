using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExceptionDemo
{
    public class MoodAnalyser
    {

        private string message;
        public MoodAnalyser(string message)
        {
            this.message = message;
        }

        public string analyseMood()
        {
            try
            {
                if (this.message.Equals(null))
                {
                    throw new MoodAnalyserException(MoodAnalyserException.ExceptionType.EMPTY_MESSAGE, message);
                }
                if (this.message.Contains("sad"))
                {
                    return "SAD";
                }
                else
                {
                    return "HAPPY";
                }
            }
            catch (Exception)
            {
                return "HAPPY";
            }
        }
    }

}
