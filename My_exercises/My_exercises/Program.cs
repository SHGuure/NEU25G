// Variabler

// 1. Hälsa på användaren
Console.WriteLine("Skriv ditt namn");

string namn = Console.ReadLine();
Console.WriteLine("Hej David");

//----------------------------------------------------------------

// 2. Multiplicera två tal

Console.WriteLine("Skriv första talet");
string inputOne = Console.ReadLine();

Console.WriteLine("Skriv andra talet");
string inputTwo = Console.ReadLine();

////convert string to int
int numberOne = Int32.Parse(inputOne);
int numberTwo = Int32.Parse(inputTwo);

//// calculate the multiplication

int result = numberOne * numberTwo;

//// Display the result
Console.WriteLine("Resultatet är: " + result);

//----------------------------------------------------------------

// 3. Varifiera lösenord

Console.WriteLine("Skriv ditt lösenord");
string input = Console.ReadLine();

string password = "abc123";

if (password == input)
{
    Console.WriteLine("Rätt lösenord");
}
else
{
    Console.WriteLine("Fel lösenord");
}

//----------------------------------------------------------------

// 4. Jämför tal

Console.WriteLine("Skriv ett tal");
string newInput = Console.ReadLine();
int number = Int32.Parse(input);

int i = 100;

if (number < i)
{
    Console.WriteLine("Talet är mindre än " + i);
}
else if (number > i)
{
    Console.WriteLine("Talet är större än " + i);
}
else if (number == i)
{
    Console.WriteLine("Talet är lika med " + i);
}