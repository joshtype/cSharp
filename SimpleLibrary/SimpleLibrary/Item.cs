﻿// Defines Item superclass obj
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleLibrary
{
    internal abstract class Item
    {
        // Parent attributes
        private string title;

        // constructors
        public Item()
        {
            this.title = "";
        }
        public Item(string initTitle)
        {
            this.title = initTitle;
        }

        // getters & setters
        public string getTitle() { return this.title; }
        public void setTitle(string newTitle) { this.title = newTitle; }

        // abstract method
        public abstract string getListing();

        // override ToString()
        public override string ToString()
        {
            return "Item title: " + this.title;
        }
    }
}
