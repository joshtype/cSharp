using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExceptionHandler_MiliTimeDiff
{
    internal class InvalidTimeException : Exception
    {
        // #1: empty constr
        public InvalidTimeException() { }

        // #2: param'd constr, arg m = ea err message, pass m to base (parent)
        public InvalidTimeException(string m) : base(m) { }
    }
}
