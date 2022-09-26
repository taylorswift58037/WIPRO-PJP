using System;

namespace Fruit
{
    class Fruit
    {
        public string name { get; set; }
        public string taste { get; set; }
        public string attri { get; set; }
        public int size { get; set; }
        public void eat()
        {
            Console.WriteLine("Fruit");
            Console.WriteLine("Taste");
        }
    }
    class Apple:Fruit
    {
        new public void eat()

        {
            Console.WriteLine("Fruit is "+ this.name);
            Console.WriteLine("Taste is "+ this.taste);
        }
    }
    class Orange:Fruit
    {
        new public void eat()
        {
            Console.WriteLine("Fruit is Orange");
            Console.WriteLine("Taste is sour");
        }
    }
    class mainclass
    {
        static void Main(string[] args)
        {
            Apple A1 = new Apple();
            A1.name = "Apple";
            A1.taste = "Sweet";
            A1.eat();
            Orange O1 = new Orange();
            O1.eat();
           
        }
    }
}
