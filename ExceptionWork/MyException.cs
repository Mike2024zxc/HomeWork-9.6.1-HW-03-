using System;
using System.Collections.Generic;
using System.Text;

namespace ExceptionWork
{
    public class MyException : Exception
    {
        public MyException()
        { }

        public MyException(string message)
            : base(message)
        { }
    }
}
