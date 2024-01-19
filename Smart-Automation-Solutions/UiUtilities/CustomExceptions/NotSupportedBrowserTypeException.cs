using System.Runtime.Serialization;

namespace UiUtilities.CustomExceptions
{
    [Serializable]
    public class NotSupportedBrowserTypeException : Exception
    {
        public NotSupportedBrowserTypeException()
        {
        }

        public NotSupportedBrowserTypeException(string? message) : base(message)
        {
        }

        public NotSupportedBrowserTypeException(string? message, Exception? innerException) : base(message, innerException)
        {
        }

        protected NotSupportedBrowserTypeException(SerializationInfo info, StreamingContext context) : base(info, context)
        {
        }
    }
}
