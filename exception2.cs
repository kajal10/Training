using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp27
{
    public class DevideByOddNumberException: ApplicationException
    {
        public override String Message
        {
            get
            {
                return "attempted to devide by zero";
            }
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
               
                Console.WriteLine("enter the first number");
                int a = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("enter the second number");
                int y = Convert.ToInt32(Console.ReadLine());

                int z = y / a;
                Console.WriteLine("result is" + z);
                if(a%y>0)
                {
                    throw new DevideByOddNumberException();

                }


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
            catch (Exception e)
            {
                Console.WriteLine(e.Message);

            }
            finally
            {
                Console.WriteLine("finally block is executed");
            }
            Console.WriteLine("end of program");

            Console.ReadKey();
        }
    }
}
