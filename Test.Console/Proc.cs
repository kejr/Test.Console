using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Test.Console
{
    public class Proc
    {
        public static void AskName(out string first, out string last)
        {
            System.Console.Write("Enter your first name: ");
            first = System.Console.ReadLine();
            System.Console.Write("Enter your last name: ");
            last = System.Console.ReadLine();
        }
    }
}
