using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp9
{
    class SuperClass
    {
     public virtual  void methodOfSuperClass()
        {
           Console.WriteLine("From Super Class");
        }
    }

    class SubClass : SuperClass
    {
    public override void methodOfSuperClass()
    {

            Console.WriteLine("From Sub Class");
            base.methodOfSuperClass();
        }
    }

    public class MethodOverriding
    {
        public static void Main(String[] args)
        {
                 
            SubClass subclass = new SubClass();
            subclass.methodOfSuperClass();
            Console.ReadKey();
        }
    }
}
