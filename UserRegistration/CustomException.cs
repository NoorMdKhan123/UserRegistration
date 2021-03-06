using System;
using System.Collections.Generic;
using System.Text;

namespace UserRegistration
{
    public class CustomException : Exception
    {
        ExceptionType type;
        public string message;

        public enum ExceptionType
        {
            NULL_MESSAGE, EMPTY_MESSAGE, INVALID_MESSAGE
        }
        public CustomException(ExceptionType type, string message) : base(message)
        {
            this.type = type;
        }
    }
}