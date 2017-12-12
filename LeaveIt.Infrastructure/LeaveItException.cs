using System;

namespace LeaveIt.Infrastructure
{
    public class LeaveItException : Exception
    {
        public LeaveItException(string message) : base(message) { }
    }
}
