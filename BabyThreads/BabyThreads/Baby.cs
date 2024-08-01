// Joshua Gregory; July 2024
// Threading Example; Baby class
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BabyThreads
{
    internal class Baby
    {
        private int time;
        private string name;

        public Baby() { }
        public Baby(string nameIn)
        {
            this.name = nameIn;        // name = arg
            Random r = new Random();   // time = rand obj 
            this.time = r.Next(5000);  // Next(5000)
        }

        public void Run()
        {
            try
            {
                Console.WriteLine($"My name is {this.name}.\nI am going to sleep for {this.time} ms.");
                Thread.Sleep(time);
                Console.WriteLine($"My name is {this.name}, I am awake, feed me!!!");
            }
            catch (ThreadInterruptedException e)
            {
                Console.WriteLine("Thread was interrupted: " + e);
            }
        }
    }
}
