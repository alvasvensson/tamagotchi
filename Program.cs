using Namespace;

Tamagotchi myTama = new();


Console.WriteLine("What do you want to name your Tamagotchi?");
Console.WriteLine("  .^._.^.");
Console.WriteLine("  | . . |");
Console.WriteLine(" (  ---  )");
Console.WriteLine(" .'     '.");
Console.WriteLine(@" |/     \|");
Console.WriteLine(@"  \ /-\ /");
Console.WriteLine("   V   V");
myTama.Name = Console.ReadLine();

while (myTama.GetAlive() == true)
{

    myTama.PrintStats();

    Console.WriteLine("What do you want to do with your tamagotchi?");
    Console.WriteLine("1.feed 2.teach new word 3.say hi 4.nothing");
    string reply = Console.ReadLine();

    if (reply == "1")
    {
        myTama.Feed();
    }

    if (reply == "2")
    {
        Console.WriteLine("what word do you want to teach?");
        string word = Console.ReadLine();
        myTama.Teach(word);
    }

    if (reply == "3")
    {
        myTama.Hi();
    }

    myTama.Tick();

}

Console.WriteLine("  .^._.^.");
Console.WriteLine("  | x x |");
Console.WriteLine(" (  ---  )");
Console.WriteLine(" .'     '.");
Console.WriteLine(@" |/     \|");
Console.WriteLine(@"  \ /-\ /");
Console.WriteLine("   V   V");
Console.WriteLine("oh no you tamagotchi died! GAME OVER");

Console.ReadLine();