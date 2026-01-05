using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp8
{
    class Program
    {
        static void Main(string[] args)
        {
            grandmom g1 = new grandmom();
            mom m1 = new mom();
            child c1 = new child();
            Console.ReadKey();
        }
    }

    class grandmom
    {
        public int year, high, age;
        public string name;
        public grandmom()
        {
            Console.WriteLine("year:");
            year = int.Parse(Console.ReadLine());
            Console.WriteLine("high:");
            high = int.Parse(Console.ReadLine());
            Console.WriteLine("name:");
            name = Console.ReadLine();

            age = 1404 - year;
            Console.WriteLine(name + "  " + high + "  " + age);
        }
    }

    class mom : grandmom
    {
        public mom()
        {
            Console.WriteLine("year:");
            year = int.Parse(Console.ReadLine());
            Console.WriteLine("high:");
            high = int.Parse(Console.ReadLine());
            Console.WriteLine("name:");
            name = Console.ReadLine();

            age = 1404 - year;
            Console.WriteLine(name + "  " + high + "  " + age);
        }
    }


    class child : mom
    {
        public child()
        {
            Console.WriteLine("year:");
            year = int.Parse(Console.ReadLine());
            Console.WriteLine("high:");
            high = int.Parse(Console.ReadLine());
            Console.WriteLine("name:");
            name = Console.ReadLine();

            age = 1404 - year;
            Console.WriteLine(name + "  " + high + "  " + age);
        }
    }
}

