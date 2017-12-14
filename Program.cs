using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Higher_Lower
{
    class Program
    {
        static void Main(string[] args)
        {
            Random r = new Random();
            Digit digit = new Digit(r.Next(0,99));
            User user = new User();
            Game g = new Game();

            while(user.getInput() != digit.getValue())
            {
                Console.Write("Zgadnij liczbę!: "); user.setInput(Convert.ToInt32(Console.ReadLine()));
                g.Equals(user, digit);
            }

            Console.ReadKey();
        }
    }
}
