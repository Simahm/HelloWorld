using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelloWorld
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Indtast dit navn");
            string name = Console.ReadLine();
            Console.WriteLine("Velkommen {0}", name.ToUpper());
            Console.WriteLine("Tryk på en tast for at fortsætte...");
            Console.ReadKey();
        }
    }
}
