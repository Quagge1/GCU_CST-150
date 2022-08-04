using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Activity11
{
    internal class Driver
    {
        public static void Main(String[] args)
        {
            //creating dice
            Dice die1 = new Dice();
            Dice die2 = new Dice();

            
            //variable for number of rolls
            int rollCount;

            rollCount = 0;

            //do while loop to roll the dice unless they are both 1 or snake eyes
            do
            {
                die1.roll();
                die2.roll();
                rollCount++;

            } while ((die1.getValue() != 1) || (die2.getValue() != 1));



            Console.WriteLine("It took " + rollCount + " rolls for you to roll snake eyes.");
        }

    }
}

