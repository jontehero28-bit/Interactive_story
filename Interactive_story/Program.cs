
Console.WriteLine("Hello, who are you?");

string name = Console.ReadLine();
string ship = Console.ReadLine();
Console.WriteLine($"Hello there, {name}");

if (name == "Space Cowboy")
{
    Console.WriteLine("What is the name of your ship then?");

    if (ship == "Bebop")
    {
        Console.WriteLine("Okay, so it is you huh? I expected you to be bigger");
        Console.ReadLine();
    }

}
else
{
    Console.WriteLine("You are not the one I been waiting for. Die *shoots you*");
}

Console.ReadLine();




