// Class creates BluRayDisc objs for BluRayCollection linked lists.
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BluRayLinkedList
{
    internal class BluRayDisc
    {
        // instance fields
        public string title, director;
        public int year;
        public double cost;

        public BluRayDisc() { }
        public BluRayDisc(string title, string director, int year, double cost)
        {
            this.title = title;
            this.director = director;
            this.year = year;
            this.cost = cost;
        }

        public override string ToString()
        {
            return $"${this.cost} {this.year} {this.title}, {this.director}";
        }
    }
}
