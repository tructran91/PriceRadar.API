using PriceRadar.Application.Common;

namespace PriceRadar.Application.Exceptions
{
    public class DuplicateException : Exception
    {
        public DuplicateException() : base(MessageConstant.DuplicateException) { }

        public DuplicateException(string message) : base(message) { }

        public DuplicateException(string message, Exception exception) : base(message, exception) { }
    }
}
