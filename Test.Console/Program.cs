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
            string first;
            string last;
            Proc.AskName(out first, out last);
            System.Console.WriteLine("Hello, {0} {1} !", first, last);
            System.Threading.Thread.Sleep(2000);
        }
    }
}
