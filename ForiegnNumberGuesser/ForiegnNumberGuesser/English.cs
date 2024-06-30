// Defines English subclass obj
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ForiegnNumberGuesser
{
    internal class English : Language
    {
        // override Language abstract methods
        public override string makeGuess()
        {
            return "Guess a number [0,100]:";
        }
        public override string tooLow()
        {
            return "Too low. Next guess:";
        }
        public override string tooHigh()
        {
            return "Too high. Next guess:";
        }
        public override string correct()
        {
            return "Correct!";
        }
    }
}
