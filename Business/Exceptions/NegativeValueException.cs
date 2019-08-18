using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Exceptions
{
    public class NegativeValueException : Exception
    {
        public NegativeValueException(int value) : base(String.Format($"Can't input value: {value} into converter. Only positive numbers."))
        {
        }
    }
}
