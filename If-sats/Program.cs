Console.WriteLine("Vad heter du");
string name = Console.ReadLine();

if (name == "John")
{
    Console.WriteLine("Hej John");
}
else if (name == "Kalle")
{
    Console.WriteLine("Hej Kalle");
}
else if (name == "Allan")
{
    Console.WriteLine("Hej Allan");
}
else
{
    Console.WriteLine("No name");
}

Console.WriteLine();

switch (name)
{
    case "John":
        Console.WriteLine("Du heter John");
        break;
    case "Anders":
        Console.WriteLine("Du heter Anders");
        break;
    case "Kallle":
        Console.WriteLine("Du heter Kalle");
        break;
    default:
        Console.WriteLine("Du heter verkan John, Anders eller Kalle");
        break;
}