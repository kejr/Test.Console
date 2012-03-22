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
            System.Console.Write("Enter your first name: ");
            string first = System.Console.ReadLine();
            System.Console.Write("Enter your last name: ");
            string last = System.Console.ReadLine();
            System.Console.WriteLine("Hello {0} {1} !", first, last);
            System.Threading.Thread.Sleep(2000);
        }
    }
}
