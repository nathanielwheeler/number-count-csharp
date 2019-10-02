using System;

namespace numguess
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Clear();
            Console.WriteLine(@"
    _   __      __  __               _          ______                    
   / | / /___ _/ /_/ /_  ____ _____ ( )_____   / ____/_  ______           
  /  |/ / __ `/ __/ __ \/ __ `/ __ \|// ___/  / /_  / / / / __ \          
 / /|  / /_/ / /_/ / / / /_/ / / / / (__  )  / __/ / /_/ / / / /          
/_/ |_/\__,_/\__/_/ /_/\__,_/_/ /_/ /____/  /_/    \__,_/_/ /_/           
    _   __                __                 ______                     __
   / | / /_  ______ ___  / /_  ___  _____   / ____/_  _____  __________/ /
  /  |/ / / / / __ `__ \/ __ \/ _ \/ ___/  / / __/ / / / _ \/ ___/ ___/ / 
 / /|  / /_/ / / / / / / /_/ /  __/ /     / /_/ / /_/ /  __(__  |__  )_/  
/_/ |_/\__,_/_/ /_/ /_/_.___/\___/_/      \____/\__,_/\___/____/____(_)   
                                                                          
            \n
            ");
            System.Console.WriteLine("Press any key to continue, or press 'q' to exit.\n");


            if (Console.ReadKey().KeyChar != 'q')
            {
                bool guessing = true;
                Random random = new Random();
                int secretNumber = random.Next(-1, 101);

                while (guessing)
                {
                    Console.Clear();
                    System.Console.WriteLine("Guess a number from 0 to 100, inclusive\n");


                }
            }
            else
            {
                Console.Clear();
                System.Environment.Exit(1);
            }

        }
    }
}
