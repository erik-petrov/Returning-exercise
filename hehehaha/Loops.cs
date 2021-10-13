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
            /*Ex1();
            Ex2();
            Ex3();
            Ex4();
            Ex5();*/
            OwnEx();
            Console.ReadLine();
        }

        private static void Ex1()
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
        private static void Ex2()
        {
            /*int[] arr = new int[5];
            for (int i = 0; i < 5; i++)
            {
                Console.Write("Please enter a number: ");
                int smt = Convert.ToInt32(Console.ReadLine());
                arr[i] = smt;
            }
            int mult = 1;
            foreach (var item in arr)
            {
                mult = item * mult;
            }
            Console.WriteLine($"Nums AVG = {arr.Average()}\nNums SUM = {arr.Sum()}\nNums multiplied = {mult}");*/
            int mult = 1;
            int sum = 0;
            for (int i = 0; i < 5; i++)
            {
                Console.Write("Please enter a number: ");
                int smt = Convert.ToInt32(Console.ReadLine());
                sum += smt;
                mult = smt * mult;
            }
            Console.WriteLine($"Nums AVG = {sum / 5}\nNums SUM = {sum}\nNums multiplied = {mult}");
        }
        private static void Ex3()
        {
            string guess;
            do
            {
                Console.Write("SAY 'elephant': ");
                guess = Console.ReadLine();
            } while (guess != "elephant");
            Console.WriteLine("thanks.");
        }
        private static void Ex4()
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
        private static void Ex5()
        {
            
            int[,] table = new int[10, 10];
            for (int i = 0; i < 10; i++)
            {
                for (int j = 0; j < 10; j++)
                {
                    table[i, j] = j+1;
                }
            }
            for (int i = 0; i < table.GetLength(0); i++)
            {
                for (int j = 0; j < table.GetLength(1); j++)
                {
                    Console.Write($"{table[i, j] * (i+1)} ");
                }
                Console.WriteLine();
            }
        }
        private static void OwnEx()
        {
            int arv;
            int[] arvud = new int[4];
            Random rnd = new Random();
            for (int i = 0; i < 4; i++)
            {
                arv = rnd.Next(1, 9);
                arvud[i] = arv;
            }
            Array.Sort(arvud);
            Array.Reverse(arvud);
            double arv4 = 0;
            for (int i = 0; i < arvud.Length; i++)
            {
                arv4 = arvud[i] * (Math.Pow(10, Math.Abs(i-arvud.Length)-1)) + arv4;
            }
            Console.WriteLine($"{arv4}");
        }
    }
}
