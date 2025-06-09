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
        private Menu? _menu;
        private string _name;
        private DateTime _date;
        private List<Results> _results;
        Random random = new Random();
        
        public Games(string name, DateTime date, List<Results> results)
        {
            _name = name;
            _date = date;
            _results = results;
        }
        public void SetMenu(Menu menu)
        {
            _menu = menu;
        }
        internal void AdditionGame()
        {
            int score = 0;
            Console.WriteLine("Welcome to Addition game!");
            Console.WriteLine("When you are ready press any key...");
            Console.ReadKey();
            for(int i = 0; i < 5; i++)
            {
                int number1 = random.Next(1, 30);
                int number2 = random.Next(1, 30);

                Console.WriteLine($"{number1} + {number2} =");
                string? input = Console.ReadLine();
                int result;
                if(int.TryParse(input, out result))
                {
                    if (result == number1 + number2)
                    {
                        score++;
                    }
                }
                else
                {
                    Console.WriteLine("Invalid input, please input the number !!!");
                    continue;
                }                
            }
            if(score > 3)
            {
                _results.Add(new Results
                {
                    ResultName = _name,
                    ResultDate = _date,
                    ResultScore = score
                });
                _menu.CongratulationsMethod(_name, _date, score);
            }
            else
            {
                _results.Add(new Results
                {
                    ResultName = _name,
                    ResultDate = _date,
                    ResultScore = score
                });
                _menu.LoserMethod(_name, _date, score);
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
                string? input = Console.ReadLine();
                int result;

                if (int.TryParse(input, out result))
                {
                    if (result == number1 - number2)
                    {
                        score++;
                    }
                }
                else
                {
                    Console.WriteLine("Invalid input, please input the number !!!");
                    continue;
                }
            }
            if(score > 3)
            {
                _results.Add(new Results
                {
                    ResultName = _name,
                    ResultDate = _date,
                    ResultScore = score
                });
                _menu.CongratulationsMethod(_name, _date, score);
            }
            else
            {
                _results.Add(new Results
                {
                    ResultName = _name,
                    ResultDate = _date,
                    ResultScore = score
                });
                _menu.LoserMethod(_name, _date, score);
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
                string? input = Console.ReadLine();
                int result;

                if (int.TryParse(input, out result))
                {
                    if (result == number1 * number2)
                    {
                        score++;
                    }
                }
                else
                {
                    Console.WriteLine("Invalid input, please input the number !!!");
                    continue;
                }
            }
            if (score > 3)
            {
                _results.Add(new Results
                {
                    ResultName = _name,
                    ResultDate = _date,
                    ResultScore = score
                });
                _menu.CongratulationsMethod(_name, _date, score);
            }
            else
            {
                _results.Add(new Results
                {
                    ResultName = _name,
                    ResultDate = _date,
                    ResultScore = score
                });
                _menu.LoserMethod(_name, _date, score);
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
                string? input = Console.ReadLine();
                int result;

                if(int.TryParse(input, out result))
                {
                    if (result == number1 / number2)
                    {
                        score++;
                    }
                }
                else
                {
                    Console.WriteLine("Invalid input, please input the number !!!");
                    continue;

                }                
            }

            if (score > 3)
            {
                _results.Add(new Results
                {
                    ResultName = _name,
                    ResultDate = _date,
                    ResultScore = score
                });
                _menu.CongratulationsMethod(_name, _date, score);
            }
            else
            {
                _results.Add(new Results
                {
                    ResultName = _name,
                    ResultDate = _date,
                    ResultScore = score
                });
                _menu.LoserMethod(_name, _date, score);
            }
        }
    }
}
