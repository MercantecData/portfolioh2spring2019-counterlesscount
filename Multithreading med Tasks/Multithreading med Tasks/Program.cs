using System;
using System.Threading.Tasks;

namespace Multithreading_med_Tasks
{
    class Program
    {
        static void Main(string[] args)
        {
            Game game = new Game();
            Console.WriteLine("Please enter your name");
            string p1 = Console.ReadLine();
            game.GameIntro(p1);
            Task.Run(game.NumberGenerator);
            Console.ReadLine();
        }
    }


    class Game
    {
        public void GameIntro(string a)
        {
            Console.WriteLine("Wellcome to the hardest game on earth!");
            Console.WriteLine("Are you ready to loose {0}", a, "?");
            Console.WriteLine("Please press any button to start the game:");
            Console.ReadLine();
        }


        public async Task CountDown()
        {
            for (int i = 0; i < 11; i++)
            {
                Console.WriteLine("You have {0}", 10 - i + " seconds left");
                await Task.Delay(1000);
            }            
        }
        public async Task NumberGenerator()
        {
            Random random = new Random();
            int x = random.Next(1, 10);
            
            for (int i = 0; i < 20; i++)
            {
                await Task.Run(CountDown);
                Console.WriteLine("Test");
            }
            
        }


    }


}
