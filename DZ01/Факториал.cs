using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
 
namespace Factorial
{
    class Program
    {
        static void Main(string[] args)
        {
            int s;
            int F = 1;
            for (s = 5; s > 1; s--)
                F = F * s;
            Console.WriteLine("Факториал 5  = " + F);
 
 
            Console.ReadLine();
        }
    }
}