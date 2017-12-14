using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Higher_Lower
{
    class Game
    {
        public static int counter = 1;
        
        public void Equals(User u, Digit d)
        {
            if (u.getInput() == d.getValue()) Console.WriteLine("Gratulacje, trafiłeś za {0} razem!", counter);
            if (u.getInput() < d.getValue()) { Console.WriteLine("Liczba mniejsza od oczekiwanej, próba nr: {0}", counter); counter++; }
            else if (u.getInput() > d.getValue()) { Console.WriteLine("Liczba większa od oczekiwanej, próba nr: {0}", counter); counter++; }
        }

    }
}
