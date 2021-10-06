using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hehehaha
{
    class Start
    {
        public static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            Exercises ex = new Exercises();
            Console.Write("Привет, как тебя зовут?: ");
            string _ = Console.ReadLine();
            ex.Neighbours();
            ex.Calculations();
            ex.Height();
            ex.HeightGender();
            ex.Temperature();
            ex.Shop();
            Console.ReadLine();
        }
    }
}
