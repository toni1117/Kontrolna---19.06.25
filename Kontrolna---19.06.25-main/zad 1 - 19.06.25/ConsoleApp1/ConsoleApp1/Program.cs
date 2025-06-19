namespace ConsoleApp1;

class Program
{
    static void Main(string[] args)
    {
        string text = Console.ReadLine();
        Dictionary<char, int> counts = new Dictionary<char, int>();

        foreach (char ch in text)
        {
            if (char.IsLetter(ch))
            {
                char letter = char.ToLower(ch);
                if (!counts.ContainsKey(letter))
                {
                    counts[letter] = 1;
                }
                else
                {
                    counts[letter]++;
                }
            }
        }

        foreach (char ch in text)
        {
            char letter = char.ToLower(ch);
            if (char.IsLetter(ch) && counts[letter] > 1)
            {
                Console.WriteLine($"{letter} -> {counts[letter]}");
                counts[letter] = 0;
            }
        }
    }
}