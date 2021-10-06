using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hehehaha
{
    class Calculations
    {
        public Calculations()
        {
            Console.Write("Напиши длинну первой стены: ");
            int a = Convert.ToInt32(Console.ReadLine());
            int b = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine($"Площадь комнаты: {a * b}");
            Random rnd = new Random();
            int numb = rnd.Next(1, 30);
            Console.WriteLine($"Твоя цена: {numb}\n30% от вашей цены: {numb * 0.7}");
        }
    }
}
