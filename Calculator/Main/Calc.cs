using System;
using System.Collections.Generic;
using System.Text;

namespace Calculator.Main
{
  static  class Calc
    {
        static int a, b,e=1;
        static string c, d;
       public static void Details()
        {

            Again:
            Console.WriteLine("Write the first number");
            c = Console.ReadLine();
            if(int.TryParse(c, out e))
            {
                a = Int32.Parse(c);
            }
            else
            {
                Console.WriteLine("You have entered wrong value");
                goto Again;
            }
            Again2:
            Console.WriteLine("Write the Second no");
            d = Console.ReadLine();

            if (int.TryParse(d, out e))
            {
                b = Int32.Parse(d);
            }
            else
            {
                Console.WriteLine("You have entered wrong value");
                goto Again2;
            }
       
        }
       public static int Addition()
        {
            return a + b;
        }
        public static int Sub()
        {
            return a - b;
        }
        public static float divide()
        {
            return a / b;
        }
    }
}
