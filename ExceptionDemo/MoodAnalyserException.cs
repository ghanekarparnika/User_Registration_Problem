using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExceptionDemo
{
    public class MoodAnalyserException : Exception
    {
        public enum ExceptionType
        {
            NULL_MESSAGE, EMPTY_MESSAGE, NO_SUCH_METHOD, NO_SUCH_CLASS, OBJECT_CREATION_ISSUE, CLASS_NOT_FOUND, CONSTRUCTOR_NOT_FOUND
        }

        public ExceptionType type;
        public MoodAnalyserException(ExceptionType type, string message) : base(message)
        {

            this.type = type;
        }
    }
}
