using System;

namespace Duck
{
    class SuperDuck
    {
        public virtual void eat()
        {
            Console.WriteLine("I dont eat");
        }
    }
    class MyDuck: SuperDuck
    {
        public override void eat()
        {
            Console.WriteLine("I am eating food…");
        }
    }
    class ToyDuck : SuperDuck
    {
        public override void eat()
        {
            Console.WriteLine("My food is electrons…");
        }
    }
    class Duck
    {
        static void Main(string[] args)
        {
            SuperDuck D1 = new MyDuck();
            SuperDuck D2 = new ToyDuck();

            while(true)
            {
                Console.WriteLine("1.Press 1 for Feeding your Duck \n2.Press 2 for feeding the Toy duck");
                int a=Convert.ToInt32(Console.ReadLine());
                switch(a)
                {
                    case 1:
                        D1.eat();
                        break;

                    case 2:
                        D2.eat();
                        break;

                    default:
                        break;
                        
                }
            }
            
        }
    }
}
