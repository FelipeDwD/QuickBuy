using System;
using System.Runtime.Serialization;

namespace Dwd.Lab.Dominio.ObjetoDeValor
{
    [Serializable]
    public class ExceptionInput : Exception
    {
        public ExceptionInput()
        {
        }

        public ExceptionInput(string message) : base(message)
        {
        }

        public ExceptionInput(string message, Exception innerException) : base(message, innerException)
        {
        }

        protected ExceptionInput(SerializationInfo info, StreamingContext context) : base(info, context)
        {
        }
    }
}