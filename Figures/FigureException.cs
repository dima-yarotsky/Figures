using System.Runtime.Serialization;

namespace Figures
{
    [Serializable]
    public class FigureException : Exception
    {
        public FigureException()
        {
        }

        public FigureException(string? message) : base(message)
        {
        }

        public FigureException(string? message, Exception? innerException) : base(message, innerException)
        {
        }

        public FigureException(SerializationInfo info, StreamingContext context) : base(info, context)
        {
        }
    }
}