using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading.Tasks.Sources;

namespace Math_Game
{
    internal class Games
    {
        Random random = new Random();
        internal void AdditionGame()
        {
            int score = 0;
            Console.WriteLine("Welcome to Addition game!");
            Console.WriteLine("When you are ready press any key...");
            Console.ReadKey();
            for(int i = 0; i < 5; i++)
            {
                int number1 = random.Next(1, 10);
                int number2 = random.Next(1, 10);

                Console.WriteLine($"{number1} + {number2} =");
                string? result = Console.ReadLine();

                if(Convert.ToInt32(result) == number1 + number2)
                {
                    score++;   
                }
            }
            if(score > 3)
            {
                Console.WriteLine($"Congratulations, your score is {score}.");
                Thread.Sleep(1000);
                Environment.Exit(0);
            }
            else
            {
                Console.WriteLine($"Maybe you will have better luck next time, your score is {score}.");
                Thread.Sleep(1000);
                Environment.Exit(0);
            }
        }

        internal void SubstractionGame()
        {
            int score = 0;
            Console.WriteLine("Welcome to Substraction game!");
            Console.WriteLine("When you are ready press any key...");
            Console.ReadKey();
            for(int i = 0; i < 5; i++)
            {
                int number1, number2;
                do
                {
                    number1 = random.Next(10, 99);
                    number2 = random.Next(1, 50);
                } while (number1 <= number2);

                Console.WriteLine($"{number1} - {number2} =");
                string? result = Console.ReadLine();

                if (Convert.ToInt32(result) == number1 - number2)
                {
                    score++;
                }
            }
            if(score > 3)
            {
                Console.WriteLine($"Congratulations, your score is {score}.");
                Thread.Sleep(1000);
                Environment.Exit(0);
            }
            else
            {
                Console.WriteLine($"Maybe you will have better luck next time, your score is {score}.");
                Thread.Sleep(1000);
                Environment.Exit(0);
            }
        }

        internal void MultiplicationGame()
        {
            int score = 0;
            Console.WriteLine("Welcome to Multiplication game!");
            Console.WriteLine("When you are ready press any key...");
            Console.ReadKey();
            for (int i = 0; i < 5; i++)
            {
                int number1 = random.Next(1, 10);
                int number2 = random.Next(1, 10);

                Console.WriteLine($"{number1} * {number2} =");
                string? result = Console.ReadLine();

                if (Convert.ToInt32(result) == number1 * number2)
                {
                    score++;
                }
            }
            if(score > 3)
            {
                Console.WriteLine($"Congratulations, your score is {score}.");
                Thread.Sleep(1000);
                Environment.Exit(0);
            }
            else
            {
                Console.WriteLine($"Maybe you will have better luck next time, your score is {score}.");
                Thread.Sleep(1000);
                Environment.Exit(0);
            }
        }

        internal void DivisionGame()
        {
            int score = 0;
            Console.WriteLine("Welcome to Division game!");
            Console.WriteLine("When you are ready press any key...");
            Console.ReadKey();
            for(int i = 0; i < 5; i++)
            {
                int number1, number2;
                do
                {
                    number1 = random.Next(1, 99);
                    number2 = random.Next(1, 10);
                } while (number1 % number2 != 0);

                Console.WriteLine($"{number1} / {number2} =");
                string? result = Console.ReadLine();

                if (Convert.ToInt32(result) == number1 / number2)
                {
                    score++;
                }
            }

            if (score > 3)
            {
                Console.WriteLine($"Congratulations, your score is {score}.");
                Thread.Sleep(1000);
                Environment.Exit(0);
            }
            else
            {
                Console.WriteLine($"Maybe you will have better luck next time, your score is {score}.");
                Thread.Sleep(1000);
                Environment.Exit(0);
            }
        }
    }
}
