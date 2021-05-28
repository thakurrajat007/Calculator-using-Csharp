using System;
using Calculator.Main;

namespace Calculator
{
    class Program
    {
        static void Main(string[] args)
        {
            top:
            string symbol;
            int total;
            float ans;
            Console.WriteLine("What kind of calculation do you want to perform??(+, -, * or /)");
            symbol = Console.ReadLine();
            if (symbol == "+")
            {
                Calc.Details();
              total=  Calc.Addition();
                Console.WriteLine(total);
            }
            else if(symbol == "-")
            {
                Calc.Details();
                total = Calc.Sub();
                Console.WriteLine(total);
            }
            else if (symbol == "/")
            {
                Calc.Details();
                ans = Calc.divide();
                Console.WriteLine(ans);
            }
            else
            {
                Console.WriteLine("Your input is wrong");
                goto top;
            }


        }
    }


     
}
