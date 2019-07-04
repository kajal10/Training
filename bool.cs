using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp20
{
    class Program
    {
        public bool Compare<T>(T a, T b)
        {

            if (a.Equals(b))
            {
                return true;
            }
            else
                return false;
        }
        public int add(int a, int b)
        {
            return(a + b);
        }
        public int mul(int a, int b)
        {
            return(a * b);
        }
        public int sub(int a, int b)
        {
            return(a - b);
        }
        static void Main(string[] args)
        {
            List<int> lst = new List<int>();

            Program p = new Program();
            lst.Add(p.add(10, 20));
            lst.Add(p.sub(10, 20));
            lst.Add(p.mul(10, 20));
            foreach (int number in lst)
                Console.WriteLine(number + "");

            Console.WriteLine(p.Compare<int>(10,20));
            Console.WriteLine(p.Compare<string>("a", "a"));



            Console.ReadKey();
        }
    }
}
