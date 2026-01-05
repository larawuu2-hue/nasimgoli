using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp10
{
    class Program
    {
        static void Main(string[] args)
        {
            passname n1 = new passname();
            n1.name = Console.ReadLine();
            n1.pass = Console.ReadLine();

            n1.method();
            Console.ReadKey();
        }
    }
    class passname
    {
        public string name = "";
        public string pass = "";


        public void method()
        {
            if (name == "admin" && pass == "123")
                Console.Write("true");
            else
                Console.WriteLine("false");
        }
    }
}