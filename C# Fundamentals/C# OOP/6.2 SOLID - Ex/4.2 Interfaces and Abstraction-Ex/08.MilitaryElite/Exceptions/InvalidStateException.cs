﻿namespace _08.MilitaryElite.Exceptions
{
    using System;

    public class InvalidStateException : Exception
    {
        private const string EXC_MESSAGE = "Inavlid mission state!";

        public InvalidStateException() : base(EXC_MESSAGE)
        {
        }

        public InvalidStateException(string message) : base(message)
        {
        }
    }
}
