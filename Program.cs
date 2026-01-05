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
            Console.WriteLine("1");
            person j1 = new person();
            Console.WriteLine();
            Console.WriteLine();

            j1.name = Console.ReadLine();
            j1.high = Console.ReadLine();
            j1.age = Console.ReadLine();
            Console.WriteLine();
            Console.WriteLine();

            Console.WriteLine("2");
            person j2 = new person();
            Console.WriteLine();
            Console.WriteLine();

            j2.name = Console.ReadLine();
            j2.high = Console.ReadLine();
            j2.age = Console.ReadLine();
            Console.WriteLine();
            Console.WriteLine();


            Console.WriteLine("result");
            Console.WriteLine();
            Console.WriteLine();
            j1.introduce();
            Console.WriteLine();
            Console.WriteLine();
            j2.introduce();
            Console.ReadKey();

        }

    }
    class person
    {
        public string name = "";
        public string high = "";
        public string age = "";

        public void introduce()
        {
            Console.WriteLine(name);
            Console.WriteLine(high);
            Console.WriteLine(age);
        }
    }

}