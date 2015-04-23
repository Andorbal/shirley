using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace git3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter your name: ");
            string name = Console.ReadLine();
            
            Console.WriteLine("Howdy");
            Console.WriteLine(name);
            Console.WriteLine("Bye bye");
            Console.ReadLine();
        }
    }
}
