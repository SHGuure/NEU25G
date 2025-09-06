// Variables (variabler) - en behållare för att lagra data (av en given typ).
// I C# måste variabler deklareras innan de kan användas

int x;
int y = 3;
double z = 3.45;
char letterA = 'A';       // Char literal values surrounded by single quetes '
string name = "Fredrik";  // String literal values surrounded by double quetes "
bool isEnabled = true;

// Literal values 
// t. ex 3, 3.45, 'A', "Fredrik", true

// Literal values kan använda sig av suffix för att avgära typen på det "hårdkodade" värdet:


// Data types (datatyper) - Anger vilken typ av data vi lagrar i t. ex en variabel

// C# är ett statiskt typat språk: Innan koden kompileras så måste data typen för varje enskild variabel vara känd

// C# är ett starkt typat språk:
// Om man försöker sätta in data av felaktig typ i en variabel så resulterar det i ett kompileringsfel
// name = 3; <= Ger ett kompileringsfel

// C# är ett typsäkert språk:
// Man kan bara utföra operationer som en given datatyp tillåter
Console.WriteLine(y + 3); // Ok och ger värdet 6
//Console.WriteLine(isEnabled + 3); <= Ottilåten operation mellan bool och int. 

// Implicit (underförstått) & explicit (uttryckligen) typade variabler

// Explicit typad variabel - Vi har uttryckligen i koden abgett att datatype på myInt är 'int'.
int myInt; // Likvärdig med Int32 myInt; Inte32 är namnet på .NET-typen, och int är C-sharps alias för Int32.

// Implicit typad variabel - Med keyword var så avgör kompilatorn datatyp.
var myVariable = 5;
myVariable = 5.3; // fel

// Scope - En variabels (ett objekts) livstid (lifetime).
// Class.scope, Method-scope & Block-scope.

bool myBool = false;

if (isEnabled)
{
    bool myOtherBool = true;
    if(1 == 1)
    {
        myBool = true;
        bool myThirdBool = true;
        Console.WriteLine(myBool);
        Console.WriteLine(myOtherBool);
        Console.WriteLine(myThirdBool);
    }

    Console.WriteLine(myBool);
    Console.WriteLine(myOtherBool);
    Console.WriteLine(myThirdBool);
}

Console.WriteLine(myBool);
Console.WriteLine(myOtherBool);
Console.WriteLine(myThirdBool);
