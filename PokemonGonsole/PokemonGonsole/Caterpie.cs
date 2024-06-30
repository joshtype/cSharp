// Defines Caterpie subclass obj
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PokemonGonsole
{
    internal class Caterpie : Pokemon
    {
        // Caterpie constructor
        public Caterpie(int initLevel)
        {
            // call parent constr
            Pokemon p = new Pokemon("Caterpie", initLevel, .1);  // random level, 10% bcr
        }

        // ToString override
        public override string ToString()
        {
            return $"level {this.getLevel()} {this.type}";
        }
    }
}
