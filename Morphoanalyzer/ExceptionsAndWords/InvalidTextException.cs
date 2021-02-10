using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;


namespace GenerationN.Exceptions
{
    [Serializable]
    public class InvalidTextException : ApplicationException
    {
        public InvalidTextException() { }
        public InvalidTextException(string message) : base(message) { }
        public InvalidTextException(string message, System.Exception inner)
            :base(message, inner) { }
        public InvalidTextException(System.Runtime.Serialization.SerializationInfo info,
            System.Runtime.Serialization.StreamingContext context) : base(info, context) { }
    }
}
