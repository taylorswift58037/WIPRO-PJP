using System;

namespace FAN
{
    class Program
    {
        static void Main(string[] args)
        {
            Fan f1 = new Fan();
            f1.print();
            f1.Speed = 2;
            f1.On = false;
            f1.print();
            f1.Speed = 4;
            f1.On = true;
            f1.print();
            Fan f2 = new Fan();
            f2.print();
            f2.Speed = 0;
            f2.print();
            f2.Speed = 3;
            f2.print();
        }
    }
}
