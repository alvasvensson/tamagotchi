namespace Namespace;
public class Tamagotchi
{
    private int hunger;
    private int boredom;
    private List<string> words = new List<string>() { "Hewwo" };
    private bool isAlive = true;
    private Random generator = new();
    public string Name;


    public void Feed()
    {
        if (hunger > 0)
        {
            hunger -= 2;
        }
        else
        {
            Console.WriteLine("Your tamagotchi is already full!");
        }
        PrintStats();
    }

    public void Hi()
    {
        ReduceBoredom();
        int wordNum = generator.Next(words.Count);
        Console.WriteLine($"{Name} says {words[wordNum]}");

    }
    public void Teach(string word)
    {
        words.Add(word);
        ReduceBoredom();
    }

    public void Tick()
    {
        boredom++;
        hunger++;

        if (boredom >= 10 || hunger >= 10)
        {
            isAlive = false;
        }
    }
    public void PrintStats()
    {
        Console.WriteLine($"hunger: {hunger}");
        Console.WriteLine($"boredom: {boredom}");
        Console.WriteLine($"alive: {isAlive}");
        Console.WriteLine("  .^._.^.");
        Console.WriteLine("  | . . |");
        Console.WriteLine(" (  ---  )");
        Console.WriteLine(" .'     '.");
        Console.WriteLine(@" |/     \|");
        Console.WriteLine(@"  \ /-\ /");
        Console.WriteLine("   V   V");
    }

    public bool GetAlive()
    {
        if (!isAlive)
        {
            return false;
        }
        else
        {
            return true;
        }
    }

    private void ReduceBoredom()
    {
        if (boredom > 0)
        {
            boredom -= 2;
        }
    }
}
