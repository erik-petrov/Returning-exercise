using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hehehaha
{
    class Alamprogramm
    {
        static void Main(string[] args)
        {
            Console.WriteLine(Avg(9,9));
            Console.Write("Please enter the first number: ");
            int num = Convert.ToInt32(Console.ReadLine());
            Console.Write("Please enter the second number: ");
            int num2 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Please enter the operation(-, + *): ");
            string operation = Console.ReadLine();
            CatCalc(num, num2, operation);
            Console.ReadLine();
        }
        static double Avg(double num, double num2)
        {
            return (num + num2) / 2;
        }
        static void CatCalc(int num, int num2, string operation)
        {
            switch (operation)
            {
                case "+":
                    for (int i = 0; i < num+num2; i++)
                    {
                        Console.Write("Purr ");
                    }
                    break;
                case "-":
                    if (num - num2 < 0)
                    {
                        for (int i = 0; i < Math.Abs(num - num2); i++)
                        {
                            Console.Write(" rruP");
                        }
                        break;
                    }
                    else {
                        for (int i = 0; i < num-num2; i++)
                        {
                            Console.Write("Purr ");
                        }
                        break;
                    } 
                case "*":
                    for (int i = 0; i < num * num2; i++)
                    {
                        Console.Write("Purr ");
                    }
                    break;
                default:
                    Console.WriteLine("Unknown operation.");
                    break;
            }
        }
        static void PrintStart()
        {
            
        }
    }
}
