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
