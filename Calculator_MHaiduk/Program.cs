using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator1_MHaiduk
{
    internal class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.Clear();
                double a, b;
                string operation;

                Console.WriteLine("Enter number 1:");
                a = double.Parse(Console.ReadLine());

                Console.WriteLine("Choose operation: '+' '-' '*' '/'");
                operation = Console.ReadLine();

                Console.WriteLine("Enter number 2:");
                b = double.Parse(Console.ReadLine());

                switch (operation)
                {
                    case "+":
                        Console.WriteLine("Your result = " + (a + b));
                        break;
                    case "-":
                        Console.WriteLine("Your result = " + (a - b));
                        break;
                    case "*":
                        Console.WriteLine("Your result = " + (a * b));
                        break;

                    case "/":
                        if (b == 0)
                        {
                            Console.WriteLine(0);
                        }
                        else
                        {
                            Console.WriteLine("Your result = " + (a / b));
                        }
                        break;

                    default:
                        Console.WriteLine("Mistake!");
                        break;
                }
                Console.ReadLine();
            }
        }
    }
}
