// Defines FibFormula implementor obj
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fibonacci_IterativeFormulaic
{
    internal class FibFormula : FindFib
    {
        public int calculateFib(int n)
        {
            // Binet's formula: F(n) = (phi^n - (1-phi)^n) / sqrt(5)
            double phi = (1 + Math.Sqrt(5)) / 2;
            double fib = (Math.Pow(phi, n) - Math.Pow(1 - phi, n)) / Math.Sqrt(5);
            return (int)Math.Round(fib);
        }
    }
}
