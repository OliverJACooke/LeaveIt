using System;

namespace LeaveIt.Infrastructurew
{
    public class LeaveItException : Exception
    {
        public LeaveItException(string message) : base(message) { }
    }
}
