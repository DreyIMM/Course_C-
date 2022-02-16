using System;
using System.Runtime.Serialization;

namespace Utilizando_Interface_IComparable.Entities
{
    [Serializable]
    internal class ArguemtnException : Exception
    {
        public ArguemtnException()
        {
        }

        public ArguemtnException(string message) : base(message)
        {
        }

        public ArguemtnException(string message, Exception innerException) : base(message, innerException)
        {
        }

        protected ArguemtnException(SerializationInfo info, StreamingContext context) : base(info, context)
        {
        }
    }
}