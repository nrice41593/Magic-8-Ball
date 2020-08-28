using System;
using System.Threading;

namespace Magic_8_Ball
{
    public class MagicBall
    {
        public static void MagicBallShaker()
        {
            Random randomResponse = new Random();
            bool conditional = true;
            Console.WriteLine("Welcome to the Virtual Magic 8 Ball");
            Thread.Sleep(2000);

            Console.WriteLine("Type question here ");
            Console.ReadLine();

            int responseIndex = randomResponse.Next(0, 19);

            string currentResponse = Responses.responses[responseIndex];
            Console.WriteLine(currentResponse);
            Thread.Sleep(500);
            ReRun();

        }

        public static void ReRun()
        {
            Console.WriteLine("Would you like to ask another question? Y or N");
            string response = Console.ReadLine().ToLower();
            if (response == "y")
            {
                Thread.Sleep(1500);
                Console.Clear();
                MagicBallShaker();
            }
            else
            {
                Environment.Exit(1);
            }
        }
    }
}
