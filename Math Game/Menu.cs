using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Math_Game
{
    internal class Menu
    {
        private Games? _games;
        private List<Results> _results;
        
        public Menu(List<Results> results)
        {
            _results = results;
        }
        public void SetGames(Games games)
        {
            _games = games;
        }
        internal void ShowMenu(string name, DateTime date)
        {
            Console.WriteLine("--------------------------------------------------------");
            Console.WriteLine($"Hello {name.ToUpper()}! It's {date.DayOfWeek}. What kind of game you want to play ?");
            Console.WriteLine("  Addition - press A");
            Console.WriteLine("  Substraction - press S");
            Console.WriteLine("  Multiplication - press M");
            Console.WriteLine("  Division - press D");
            Console.WriteLine("If you want to see previous results - press R ");
            Console.WriteLine("If you want to exit the game - press Q");
            Console.WriteLine("--------------------------------------------------------");

            string? userInput = Console.ReadLine();

            while (userInput == "" || userInput == null)
            {
                Console.WriteLine("You need to choose game type or exit the game. Try again:");
                userInput = Console.ReadLine();
            }

            switch (userInput.ToLower().Trim())
            {
                case "a":
                    _games.AdditionGame();
                    break;
                case "s":
                    _games.SubstractionGame();
                    break;
                case "m":
                    _games.MultiplicationGame();
                    break;
                case "d":
                    _games.DivisionGame();
                    break;
                case "r":
                    Console.Clear();
                    foreach (var result in _results)
                    {
                        Console.WriteLine($"On {result.ResultDate} {result.ResultName} has {result.ResultScore} points;");
                    }
                    Console.WriteLine("To back to Menu press any key...");
                    Console.ReadKey();
                    Console.Clear();
                    ShowMenu(name, date);                    
                    break;
                case "q":
                    Console.WriteLine($"Good bye {name.ToUpper()} !!!");
                    Thread.Sleep(1000);
                    Environment.Exit(0);
                    break;
                default:
                    Console.WriteLine("Invalid input!");
                    Thread.Sleep(1000);
                    Environment.Exit(1);
                    break;
            }
        }

        internal void CongratulationsMethod(string name, DateTime date, int score)
        {
            Console.WriteLine($"Congratulations, your score is {score}.");
            Console.WriteLine("Do you want to play another game ? | Press Y/N");
            string? input = Console.ReadLine();
            if (input == null || input.Trim() == "" || input.Trim().Equals("n", StringComparison.InvariantCultureIgnoreCase))
            {
                Console.WriteLine("Good Bye!!!");
                Environment.Exit(0);
            }
            if (input.Trim().Equals("y", StringComparison.InvariantCultureIgnoreCase))
            {
                Console.Clear();
                ShowMenu(name, date);
            }
            else
            {
                Console.Clear();
                CongratulationsMethod(name, date, score);
            }
        }

        internal void LoserMethod(string name, DateTime date, int score)
        {
            Console.WriteLine($"Maybe you will have better luck next time, your score is {score}.");
            Console.WriteLine("Do you want to play another game ? | Press Y/N");
            string? input = Console.ReadLine();
            if (input == null || input.Trim() == "" || input.Trim().Equals("n", StringComparison.InvariantCultureIgnoreCase))
            {
                Console.WriteLine("Good Bye!!!");
                Environment.Exit(0);
            }
            if (input.Trim().Equals("y", StringComparison.InvariantCultureIgnoreCase))
            {
                Console.Clear();
                ShowMenu(name, date);
            }
            else
            {
                Console.Clear();
                LoserMethod(name, date, score);
            }
        }
    }
}
