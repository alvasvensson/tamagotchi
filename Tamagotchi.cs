namespace Namespace;
public class Tamagotchi
{
    private int hunger;
    private int boredom;
    private List<string> words;
    private bool isAlive;
    private Random generator;
    public string Name;


    public void Feed()
    {
        hunger = -1;
        PrintStats();
    }

    public void Hi()
    {
        ReduceBoredom();
        int wordNum = generator.Next(words.Count);
        Console.WriteLine($"{Name} says {wordNum}");
        Console.ReadLine();

    }
    public void Teach(string word)
    {
        ReduceBoredom();
        words.Add(word);
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
    }

    public bool GetAlive()
    {
        return true;
    }

    private void ReduceBoredom()
    {
        boredom = -1;
    }
}
