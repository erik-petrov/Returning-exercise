using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hehehaha
{
    class Age
    {
        public Age(string name)
        {
            if (name == "h")
            {
                Console.Write("How old are you: ");
                int age = Convert.ToInt32(Console.ReadLine());
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
    }
}
