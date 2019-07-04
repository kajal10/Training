using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp20
{
    class Demo<A>
    {

        public void Add(A a, A b)
        {
            dynamic value1 = a;
            dynamic value2 = b;
            Console.WriteLine(value1 + value2);
        }
        public int mul(int a, int b)
        {
            return (a * b);
        }
        public int sub(int a, int b)
        {
            return (a - b);
        }
    }
        class Program
        {
            static void Main(string[] args)
            {
                List<int> lst = new List<int>();

                Demo<int> p = new Demo<int>();
                p.Add(10, 20);
                lst.Add(p.sub(10, 20));
                lst.Add(p.mul(10, 20));
                foreach (int number in lst)
                    Console.WriteLine(number + "");


                Console.ReadKey();
            }
        }
    }
