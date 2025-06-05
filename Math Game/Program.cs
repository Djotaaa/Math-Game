using Math_Game;

Console.WriteLine("Welcome to Math Game. Can you tell us what's your name ?");
string? name = Console.ReadLine();
DateTime date = DateTime.Now;
Games games = new Games();

while (name.Trim() == "")
{
    Console.WriteLine("It's necessary to input your name, try again:");
    name = Console.ReadLine();
}
Console.WriteLine("--------------------------------------------------------");
Console.WriteLine($"Hello {name.ToUpper()}! It's {date.DayOfWeek}. What kind of game you want to play ?");
Console.WriteLine("  Addition - press A");
Console.WriteLine("  Substraction - press S");
Console.WriteLine("  Multiplication - press M");
Console.WriteLine("  Division - press D");
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
        games.AdditionGame();
        break;
    case "s":
        games.SubstractionGame();
        break;
    case "m":
        games.MultiplicationGame();
        break;
    case "d":
        games.DivisionGame();
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

