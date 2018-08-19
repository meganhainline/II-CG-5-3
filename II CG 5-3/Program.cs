using System;

namespace CG_5_3
{
    class Program
    {
        private const int WINNING_SCORE = 20;

        static void Main(string[] args)
        {
            //initialize integer playerNo to keep the player's score
            int playerNo = 0;
            //initialize integer cpuNo to keep the computer's score
            int cpuNo = 0;

            do
            {
                //add a random number between 1-6 to playerNo
                playerNo += RollDice();
                Console.WriteLine("Player: " + playerNo);
                //do the same for cpuNo
                cpuNo += RollDice();
                Console.WriteLine("CPU: " + cpuNo);
                //do this as long as both variables have under 20 value
            } while (playerNo <= 20 && cpuNo <= 20);

            if (playerNo >= 20)
            {
                Console.WriteLine("Player wins!");
            }
            //player wins in this case too because player always moves first
            else if (cpuNo >= 20 && playerNo >= 20)
            {
                Console.WriteLine("Player wins!");
            }
            else if (cpuNo >= 20)
            {
                Console.WriteLine("CPU wins!");
            }
            else
            {
                Console.WriteLine("This shouldn't be...!");
            }

            Console.ReadLine();

        }
        /// <summary>
        /// Rolls a 6-sided die and returns the result as an integer
        /// </summary>
        /// <returns>An integer from 1-6</returns>
        private static int RollDice()
        {
            //create a random seed
            Random rnd = new Random();

            //initialize integer rollNo (within RollDice) and set it to a random number up to 6
            int rollNo = rnd.Next(1, 6);
            //return the value of rollNo to the variable rollNo (within Main)
            return rollNo;
        }
    }
}