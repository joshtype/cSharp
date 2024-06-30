// Defines Bulbasaur subclass obj
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PokemonGonsole
{
    internal class Bulbasaur : Pokemon
    {
        public Bulbasaur(int initLevel)
        {
            // call parent constr, downcast to child
            Pokemon p = new Pokemon("Bulbasaur", initLevel, .2);  // random lvl, 20% bcr
        }

        

        // ToString override
        public override string ToString()
        {
            return $"level {this.getLevel()} {this.type}";
        }

    }
}
