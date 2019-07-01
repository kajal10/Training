using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp10
{
    public abstract class AbstractClass
    {
        abstract public void abstractMethod();
    }

    class ConcreteClass : AbstractClass
    {
        public override void abstractMethod()
        {
            Console.WriteLine("hiiiiiiiiiiiii");
        }
    }

    public class Abstraction
    {
        public static void Main(String[] args)
        {
            //AbstractClass A = new AbstractClass();  Can't create objects to Abstract class
            ConcreteClass C = new ConcreteClass();
            //ConcreteClass implements abstract method,
            //so we can create object to ConcreteClass
            AbstractClass A1 = C;
            //ConcreteClass object is auto-upcasted to AbsractClass
            C.abstractMethod();
            Console.ReadKey();
        }
    }
}
