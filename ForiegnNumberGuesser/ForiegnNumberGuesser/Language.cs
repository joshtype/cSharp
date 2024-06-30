// Defines Language superclass
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ForiegnNumberGuesser
{
    abstract class Language
    {
        // abstract methods to be overridden by derived classes
        public abstract string makeGuess();
        public abstract string tooLow();
        public abstract string tooHigh();
        public abstract string correct();
    }
}
