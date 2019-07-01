 interface Animal
    {
        void eat();
        void travel();
    }
    public class MammalInt : Animal
    {
        public void eat()
        {
            Console.WriteLine("Mammal eats");
        }

        public void travel()
        {
            Console.WriteLine("Mammal travels");
        }

        public int noOfLegs()
        {
            return 0;
        }
    }
    class Class2
    {
        public static void Main(String[] args)
        {
            MammalInt m = new MammalInt();
            method1(new MammalInt());
            m.noOfLegs();
        }
        public static void method1(Animal a)
        {
            a.eat();
            a.travel();
            
        }
    }

}
