// Defines Pokemon superclass
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PokemonGonsole
{
    internal class Pokemon
    {
        // parent fields
        public string type;  // Bulbasaur, Charmander, Caterpie
        private int level;   // random [0,20]
        private double bcr;  // varies by child

        // constructors
        public Pokemon(string initType, int initLevel, double initBCR)
        {
            this.type = initType;    // set by child class
            this.level = initLevel;  // set randomly
            this.bcr = initBCR;      // varies by child class
        }

        // getters & setters
        public string getType() { return this.type; }
        public int getLevel() { return this.level; }
        public double getBaseCatchRate() { return this.bcr; }
        public void setType(string newType) { this.type = newType; }
        public void setLevel(int newLevel) { this.level = newLevel; }
        public void setBaseCatchRate(double newBCR) { this.bcr = newBCR; }

        // ToString override
        public override string ToString()
        {
            return $"level {getLevel()} {getType()}!";
        }
    }
}
