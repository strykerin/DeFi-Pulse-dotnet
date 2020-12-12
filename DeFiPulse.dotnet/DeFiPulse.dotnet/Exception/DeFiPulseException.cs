using System;

namespace DeFiPulse.Exceptions
{
    public class DeFiPulseException : Exception
    {
        public DeFiPulseException()
        {
        }

        public DeFiPulseException(string message) : base(message)
        {
        }

        public DeFiPulseException(string message, Exception inner) : base(message, inner)
        {
        }
    }
}
