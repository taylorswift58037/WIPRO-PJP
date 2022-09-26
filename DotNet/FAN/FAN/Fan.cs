using System;
using System.Collections.Generic;
using System.Text;

namespace FAN
{
    class Fan
    {
        static int SLOW = 1, MEDIUM = 2, FAST = 3;
        private int speed = SLOW;
        private bool on = false;
        private double radius = 5;
        private string color = "Red";

        public int Speed
        {
            get
            {
                if (1<=speed && speed<=3)
                {
                    return speed;
                    
                }
                else
                {
                    this.on = false;
                    return 0;
                }
            }
            set
            {
                if (1 <= value && value <= 3)
                {
                    speed =value;
                }
            }
        }
        public bool On
        {
            get
            {
                if (on = true)
                    return true;
                else
                    return false;
            }
            set
            {
                on = value;
            }
        }

        public void print()
        {
            Console.WriteLine("{0} {1} {2} {3}", speed,on, radius, color);
        }
    }
}
