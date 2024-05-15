using System;

namespace YourNamespace.Exceptions
{
    [Serializable]
    public class OverfillException : Exception
    {
        public OverfillException() 
        { 
        }

        public OverfillException(string message) : base(message) 
        { 
        }

        public OverfillException(string message, Exception inner) : base(message, inner) 
        { 
        }

        protected OverfillException(
            System.Runtime.Serialization.SerializationInfo info,
            System.Runtime.Serialization.StreamingContext context) : base(info, context) 
        { 
        }
    }
}