using System;
using System.Runtime.Serialization;

namespace Entidades
{
    [Serializable]
    internal class NoSeGuardoException : Exception
    {
        public NoSeGuardoException() : base("No se guardó al usuario.")
        {
        }

        public NoSeGuardoException(string message) : base(message)
        {
        }

        public NoSeGuardoException(string message, Exception innerException) : base(message, innerException)
        {
        }

        protected NoSeGuardoException(SerializationInfo info, StreamingContext context) : base(info, context)
        {
        }
    }
}