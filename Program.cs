using Namespace;

Tamagotchi myTama = new();


Console.WriteLine("What do you want to name yout Tamagotchi?");
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
        myTama.Tick();
    }

    if (reply == "2")
    {
        Console.WriteLine("what word do you want to teach?");
        string wordToTeach = Console.ReadLine();
        myTama.Teach(wordToTeach);
        myTama.Tick();
    }

    if (reply == "3")
    {
        myTama.Hi();
        myTama.Tick();
    }

}



Console.ReadLine();