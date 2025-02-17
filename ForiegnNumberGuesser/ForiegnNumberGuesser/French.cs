﻿// Defines French subclass obj
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ForiegnNumberGuesser
{
    internal class French : Language
    {
        // override Language abstract methods
        public override string makeGuess()
        {
            return "Devinez un nombre [0,100]:";
        }
        public override string tooLow()
        {
            return "Trop bas. Nouvelle estimation:";
        }
        public override string tooHigh()
        {
            return "Trop haut. Nouvelle estimation:";
        }
        public override string correct()
        {
            return "Correcte!";
        }
    }
}
