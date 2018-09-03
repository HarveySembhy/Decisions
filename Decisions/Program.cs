using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decisions
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Harvey's Big Giveaway");
            Console.Write("Choose a door: 1, 2 or 3: ");
            int userValue = int.Parse(Console.ReadLine());

            Console.WriteLine();

            if (userValue == 1)
            {
                string message = "You won a new car";
                Console.WriteLine(message);
            }

            if (userValue == 2)
            {
                string message2 = "Oh dear it's a snake!";
                Console.WriteLine(message2);
            }
           
            if (userValue == 3)
            {
                string message3 = "Haha it's a goat!";
                Console.WriteLine(message3);
            }

            if (userValue > 3)
            {
                string nullMessage = "Try again!";
                Console.WriteLine(nullMessage);
            }

            Console.WriteLine();
            Console.WriteLine("Thanks for playing!");

            Console.ReadLine();

            //if (userValue == "2")
            //{
            //    string = "Oh dear there is a goat here";


            //}



        }
    }
}
