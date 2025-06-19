namespace ConsoleApp1;

class Program
{
    static void Main(string[] args)
    {
        Dictionary<string, int> players = new Dictionary<string, int>();

        while (true)
        {
            string line = Console.ReadLine();

            if (line == "game over")
                break;

            string[] parts = line.Split(' ');
            string name = parts[0];
            int points = int.Parse(parts[1]);

            if (!players.ContainsKey(name))
            {
                players[name] = 0;
            }

            players[name] += points;
        }

        Console.WriteLine("");
        
        foreach (var pair in players)
        {
            Console.WriteLine($"{pair.Key} -> {pair.Value}");
        }
    }
}