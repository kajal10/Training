using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp15
{
    class A
    {
        public new string ToString()
        {
            return "{hii,hello}";
        }
    }
    class B
    {
        public override string ToString()
        {
            return "{Tata, Bye-Bye}";
        }
    }


    class Program
    {
        static void Main(string[] args)
        {
            A a = new A();
            B b = new B();

            Console.WriteLine(a.ToString());
            Console.WriteLine(b.ToString());

            Console.Read();
        }

    }
    
}
