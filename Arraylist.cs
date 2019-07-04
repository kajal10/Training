using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;


namespace ConsoleApp24
{
    class Program
    {
        static void Main(string[] args)
        {
            ArrayList list = new ArrayList();
            list.Add("Red");
            list.Add("Blue");
            list.Add("white");
            list.Add("Green");
            list.Add("Yellow");
            Console.WriteLine("Elements before swap:");

            foreach (var n in list)

                Console.WriteLine(n);
            Object a = list[1];
            list[1] = list[2];
            list[2] = a;
            list[3]= "orange";
            Console.WriteLine("Elements before swap:");

            foreach (var n in list)

                Console.WriteLine(n);
            Console.ReadKey();


        }
    }
}
