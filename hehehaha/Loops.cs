using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hehehaha
{
    class Loops
    {
        static void Main()
        {
            ex1();
            ex2();
            ex3();
            ex4();
            Console.ReadLine();
        }

        private static void ex1()
        {
            Random rnd = new Random();
            int n = rnd.Next(1, 50);
            int m = rnd.Next(51, 100);
            int n2 = n;
            int[] arr = new int[m - n];
            for (int i = 0; i < m - n; i++)
            {
                arr[i] = n2;
                n2++;
            }
            foreach (var item in arr)
            {
                Console.WriteLine(item*item);
            }
        }
        private static void ex2()
        {
            int[] arr = new int[5];
            for (int i = 0; i < 5; i++)
            {
                Console.Write("Please enter a number: ");
                int smt = Convert.ToInt32(Console.ReadLine());
                arr[i] = smt;
            }
            int sum = 0;
            int mult = 1;
            foreach (var item in arr)
            {
                sum += item;
                mult = item * mult;
            }
            Console.WriteLine($"Nums AVG = {arr.Average()}\nNums SUM = {sum}\nNums multiplied = {mult}");
        }
        private static void ex3()
        {
            string guess = "";
            do
            {
                Console.Write("SAY ELEPHANT: ");
                guess = Console.ReadLine();
            } while (guess != "elephant");
            Console.WriteLine("thanks.");
        }
        private static void ex4()
        {
            Random rnd = new Random();
            int num = rnd.Next(1, 10);
            int tries;
            for (int i = 0; i < 5; i++)
            {
                tries = 5 - i;
                Console.Write("Tries left: "+ tries +"\nGuess the number that the PC generated(1-10): ");
                int guess = Convert.ToInt32(Console.ReadLine());
                if (guess == num)
                {
                    Console.WriteLine("Nice");
                    break;
                }
                else { Console.WriteLine("No luck this time."); }
            }
        }
    }
}
