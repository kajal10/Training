using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp27
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("enter the first number");
                int x = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("enter the second number");
                int y = Convert.ToInt32(Console.ReadLine());

                int z = x / y;
                Console.WriteLine("result is" + z);



            }
            catch (DivideByZeroException e)
            {
                Console.WriteLine(e.Message);



            }
            catch (FormatException e)
            {
                Console.WriteLine("only numerioc values are allowed");

            }
            catch (OverflowException e)
            {
                Console.WriteLine(e.Message);

            }
            Console.WriteLine("end of program");

            Console.ReadKey();
        }
    }
}
