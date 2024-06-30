using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExceptionHandler_MiliTimeDiff
{
    internal class TimeInputErr : Exception
    {
        // reqs empty & param'd constructor
        public TimeInputErr() { }
        // pass m to Exception base class (m = thrown err msgs) 
        public TimeInputErr(string m) : base(m) { }
    }
}
