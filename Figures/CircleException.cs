using System.Runtime.Serialization;

namespace Figures
{
    [Serializable]
    internal class CircleException : Exception
    {
        public CircleException()
        {
        }

        public CircleException(string? message) : base(message)
        {
        }

        public CircleException(string? message, Exception? innerException) : base(message, innerException)
        {
        }

        protected CircleException(SerializationInfo info, StreamingContext context) : base(info, context)
        {
        }
    }
}