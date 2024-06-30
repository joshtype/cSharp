// Defines Charmander subclass obj
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PokemonGonsole
{
    internal class Charmander : Pokemon
    {
        // Charmander constructor
        public Charmander(int initLevel)
        {
            // type = Charmander, level = random, bcr = 20%
            Pokemon p = new Pokemon("Charmander", initLevel, .2);  // random lvl, 20% bcr
        }

        // ToString override
        public override string ToString()
        {
            return $"level {this.getLevel()} {this.type}";
        }
    }
}
