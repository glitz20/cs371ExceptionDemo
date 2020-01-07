using System;
using System.Collections.Generic;

namespace ExceptionsDemo
{
    public class Startship1: ApplicationException
    {
        public Startship1() { }

        public Startship1(string message) : base(message) { }

        public Startship1(string message, System.Exception inner) : base(message, inner)
        {
        }

        protected Startship1(
            System.Runtime.Serialization.SerializationInfo info,
            System.Runtime.Serialization.StreamingContext context)
            : base(info, context) { }

    }
}