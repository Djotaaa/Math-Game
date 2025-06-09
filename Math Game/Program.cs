using Math_Game;

Console.WriteLine("Welcome to Math Game. Can you tell us what's your name ?");
string? name = Console.ReadLine();
DateTime date = DateTime.Now;
List<Results> results = new List<Results>();

while (name.Trim() == "")
{
    Console.WriteLine("It's necessary to input your name, try again:");
    name = Console.ReadLine();
}

Menu menu = new Menu(results);
Games games = new Games(name, date, results);

menu.SetGames(games);
games.SetMenu(menu);

menu.ShowMenu(name, date);

