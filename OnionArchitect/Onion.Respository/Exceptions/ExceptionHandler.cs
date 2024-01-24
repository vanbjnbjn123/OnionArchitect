using System;
using System.Runtime.Serialization;

namespace Onion.Respository.Exceptions
{
	public class ExceptionHandler : Exception
	{
		public ExceptionHandler()
		{
		}

        public ExceptionHandler(string? message) : base(message)
        {
            
        }

        public ExceptionHandler(string? message, Exception? innerException) : base(message, innerException)
        {
        }

        protected ExceptionHandler(SerializationInfo info, StreamingContext context) : base(info, context)
        {
        }

    }
}

