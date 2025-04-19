using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace _1_lucistnik
{
    public class Archer
    {
        public string Name;
        public int NumberOfArrows;

        public Archer(string name, int numberOfArrows)
        {
            Name = name;
            NumberOfArrows = numberOfArrows;
        }
        public void BowShot()
        {

            if (NumberOfArrows > 0)
            {
                NumberOfArrows--;
                Console.WriteLine($"You shot an arrow! You have {NumberOfArrows} arrows left");

            }
            else
            {
                Console.WriteLine("You don't have any arrows left.");
            }
        }
        public void AddArrows(int number)
        {
            NumberOfArrows += number;
            if (number == 1 && NumberOfArrows == 1)
            {
                Console.WriteLine($"+ {number} arrow, total: {NumberOfArrows} arrow");
            }
            else if (number == 1 && NumberOfArrows > 1)
            {
            Console.WriteLine($"+ {number} arrow, total: {NumberOfArrows} arrows");
            }
            else {
            Console.WriteLine($"+ {number} arrows, total: {NumberOfArrows} arrows");
            }
        }

        public void ShowInfo()
        {
            Console.WriteLine($"Hi my name is {Name} and I have {NumberOfArrows} arrows");
        }

    }
}
