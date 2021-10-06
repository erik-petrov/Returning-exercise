using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hehehaha
{
    class Exercises
    {
        public void Calculations()
        {
            Console.Write("Хочешь сделать ремонт?(y/n): ");
            string decision = Console.ReadLine();
            if (decision.ToLower() == "y")
            {
                Console.Write("Напиши длинну в метрах первой стены: ");
                int a = TypeCheck();
                Console.Write("Напиши длинну в метрах второй стены: ");
                int b = TypeCheck();
                double area = a * b;
                Console.WriteLine($"Площадь комнаты: {Math.Abs(a) * Math.Abs(b)}");
                Random rnd = new Random();
                int numb = rnd.Next(1, 30);
                Console.WriteLine($"Цена паркета за метр квадратный: {numb}, стоимость ремонта: {numb*area}\n30% от вашей цены: {(numb * area) * 0.7}");
            }
            else
            {
                Console.WriteLine("Ну ладно.");
            }
        }

        public void Age(string name)
        {
            if (name == "h")
            {
                Console.Write("How old are you: ");
                int age = TypeCheck();
                if (age > 0 && age < 6)
                {
                    Console.WriteLine("Hind: tasuta");
                }
                else if (age >= 6 && age < 15)
                {
                    Console.WriteLine("Hind: 2eur");
                }
                else if (age >= 15 && age < 65)
                {
                    Console.WriteLine("Hind: 10eur");
                }
                else if (age < 100)
                {
                    Console.WriteLine("Hind: 8eur");
                }
                else
                {
                    Console.WriteLine("you're dead");
                }
            }
            else
            {
                Console.WriteLine("Hello, " + name);
            }
        }

        public void Height()
        {
            Console.Write("Какой твой рост?: ");
            int cm = TypeCheck();
            if (cm < 0 && cm < 257)
            {
                Console.WriteLine("Врун");
            }
            else if (cm > 120 && cm < 160)
            {
                Console.WriteLine("Ты довольно низкий");
            }
            else if (cm > 161 && cm < 184)
            {
                Console.WriteLine("Ты среднего роста");
            }
            else if (cm > 185 && cm < 256)
            {
                Console.WriteLine("Ты высокий");
            }
        }
        public void Temperature()
        {
            Console.Write("Какая в твоей команте обычно температура?: ");
            int degrees = TypeCheck();
            if (degrees < 0 && degrees < 31)
            {
                Console.WriteLine("Врун");
            }
            else if (degrees > 9 && degrees < 17)
            {
                Console.WriteLine("У тебя в команте довольно холодно.");
            }
            else if (degrees > 18 && degrees < 22)
            {
                Console.WriteLine("У тебя в команте тепло и приятно.");
            }
            else if (degrees > 23 && degrees < 30)
            {
                Console.WriteLine("У тебя в команте довольно жарко.");
            }
        }
        public void HeightGender()
        {
            Console.Write("Какого ты пола?(m/f): ");
            string gender = Console.ReadLine();
            Console.Write("Впиши свой рост: ");
            int cm = TypeCheck();
            switch (gender.ToLower())
            {
                case "m":
                    if (cm < 0 && cm < 257)
                    {
                        Console.WriteLine("Врун");
                    }
                    else if (cm > 120 && cm < 160)
                    {
                        Console.WriteLine("Ты довольно низкий для мужчины");
                    }
                    else if (cm > 161 && cm < 184)
                    {
                        Console.WriteLine("Ты среднего роста для мужчины");
                    }
                    else if (cm > 185 && cm < 256)
                    {
                        Console.WriteLine("Ты высокий для мужчины");
                    }
                    break;
                case "f":
                    if (cm < 0 && cm < 257)
                    {
                        Console.WriteLine("Врун");
                    }
                    else if (cm > 100 && cm < 150)
                    {
                        Console.WriteLine("Ты довольно низкая для женщины");
                    }
                    else if (cm > 161 && cm < 170)
                    {
                        Console.WriteLine("Ты среднего роста для женщины");
                    }
                    else if (cm > 171 && cm < 256)
                    {
                        Console.WriteLine("Ты высокая для женщины");
                    }
                    break;
                default:
                    break;
            }
        }
        public void Shop()
        {
            int total = 0;
            string[] products = new string[] { "Хлеб", "Молоко", "Булка" };
            Random rnd = new Random();
            foreach (var product in products)
            {
                int price = rnd.Next(1, 10);
                Console.WriteLine($"Хочешь ли ты купить {product} за {price}евро?");
                Console.Write("y/n ");
                string decision = Console.ReadLine();
                if (decision.ToLower() == "y") total += price;
            }
            Console.WriteLine("Общая стоимость товаров: " + total);
        }
        public void Neighbours()
        {
            Console.WriteLine("Кто твой сосед по парте?: ");
            string first = Console.ReadLine();
            Console.WriteLine("Кто твой второй сосед по парте?: ");
            string second = Console.ReadLine();
            if (first.ToLower() == "aleksei" && second.ToLower() == "rolan")
            {
                Console.WriteLine("У меня такие-же.");
            }
            else
            {
                Console.WriteLine("У меня другие.");
            }
        }
        private int TypeCheck()
        {
            while (true)
            {
                try
                {
                    string check = Console.ReadLine();
                    int number = Convert.ToInt32(check);
                    return number;
                }
                catch
                {
                    Console.WriteLine("Впиши число.");
                }
            }
        }
    }
}
