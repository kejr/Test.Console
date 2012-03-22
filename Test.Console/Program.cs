using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Test.Console
{
    class Program
    {
        static void Main(string[] args)
        {
            System.Console.Write("Enter your name: ");
            string name = System.Console.ReadLine();
            System.Console.WriteLine("Hello, {0} !", name);
        }
    }
}
