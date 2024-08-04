using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TwistedFizzBuzz.Exceptions
{
    public class DifferentLengthException : Exception
    {
        public DifferentLengthException(string message) : base(message) { }
    }
}
