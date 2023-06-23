﻿using PriceRadar.Application.Common;

namespace PriceRadar.Application.Exceptions
{
    public class NotFoundException : Exception
    {
        public NotFoundException() : base(MessageConstant.NotFoundException) { }

        public NotFoundException(string message) : base(message) { }

        public NotFoundException(string message, Exception exception) : base(message, exception) { }
    }
}
