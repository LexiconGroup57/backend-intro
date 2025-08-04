// See https://aka.ms/new-console-template for more information
// 
/*Console.WriteLine("Hello, World!");             // Intro line?

Console.Clear();
Console.Write("25 + ");
Console.Write("10 = ");
Console.WriteLine(35);
Console.WriteLine("A new line");
int interestRate = 5;

int result = interestRate * 12;*/

/*int x = 23;
int prognosis = x + 4;
int actual = 34 - 4 + 0;

Console.WriteLine(!(prognosis > actual));*/

/*Console.WriteLine(45 != 34 ? "red" : "yellow");

Console.WriteLine(34 + 23 + 56);

Console.WriteLine("Good" + " +" + " idea");
Console.WriteLine( 34 + 2 + "Good" + " +" + " idea" + 34 + 23 + 56);

int incremental = 5;
for (int i = 4; i < 7; i++)
{
    
    incremental = incremental + i;
    Console.WriteLine(incremental + " Hello");
}
Console.WriteLine(incremental);*/




/*
Console.WriteLine(GetComposition(45, "Hello"));
Console.WriteLine(GetComposition(23, "Good"));
Console.WriteLine(GetComposition(34, "Idea"));


string GetComposition(int factor, string text)
{
    int result = factor * 2;
    string composition = text + " " + result;
    return composition;
}

PresentComposition(45, "Hello");
PresentComposition(23, "Good");
PresentComposition(34, "Idea");


void PresentComposition(int factor, string text)
{
    int result = factor * 2;
    string composition = text + " " + result;
    Console.WriteLine(composition);
}





LearnAboutProblem();
PrototypeSolution();
SolveIssue();
PresentResult();


string LearnAboutProblem()
{
    GetContextData();
    GetStaffOpinions();
    return "problemDefinition";
}

string PrototypeSolution()
{
    
    return "Prototype";
}*/

/*
string text = "Horse";
int x = 3;

if (x == 3)
{
    Console.WriteLine("x is 3");
}
else if ( x > 2)
{
    Console.WriteLine("x is greater than 2");
}
else
{
    Console.WriteLine("No condition met");
}

Console.WriteLine("Press Enter key to continue");
string inputValue = Console.ReadLine();
Console.WriteLine(inputValue.EndsWith("know"));


if (x == 3)
{
    Console.WriteLine("x is 3");
}
if (x > 2)
{
    Console.WriteLine("x is greater than 2");
}*/


/*
int newNumber = 10;

string newText = newNumber.ToString();
string numberToParse = "10";

int parsedNumber = int.Parse(numberToParse);

if(int.TryParse(numberToParse, out int anotherNumber)){
    Console.WriteLine(anotherNumber * 45);
}
else
{
    Console.WriteLine("Not a number");   
}


decimal foo = 12.4M;

string userEntry = Console.ReadLine();

double parsedDouble = double.Parse(userEntry);
decimal parsedDecimal = decimal.Parse(userEntry);

Console.WriteLine(parsedDouble * 45);

// Console.WriteLine(parsedNumber  * 45);
*/

// Pause the execution

Console.WriteLine("Enter a key to continue");
Console.ReadKey();

Console.Clear();

Console.WriteLine("Hello, World!");

bool appRunning = true;

while (appRunning)
{
// Menu option
    Console.WriteLine("A for good");
    Console.WriteLine("B for bad");
    Console.WriteLine();
    Console.WriteLine("Enter a choice");
    ConsoleKeyInfo userInput = Console.ReadKey();

    Console.WriteLine(userInput.Key);

    char keyPressed = userInput.KeyChar;

    int taxRate = 0;
    switch (keyPressed)
    {
        case 'A' or 'a':
            Console.WriteLine("Good");
            taxRate = 11;
            MethodOne();
            break;
        case 'B' or 'b':
            Console.WriteLine("Bad");
            taxRate = 6;
            MethodTwo();
            break;
        case 'C' or 'c':
            Console.WriteLine("Bad");
            taxRate = 25;
            MethodThree();
            break;
        case 'D' or 'd':
            Console.WriteLine("Bad");
            continue;
        case 'X' or 'x':
            Console.WriteLine("Exit");
            appRunning = false;
            continue;
        default:
            Console.WriteLine("Invalid choice");
            break;
    }

    Console.WriteLine(taxRate);


    void MethodOne()
    {

    }

    void MethodTwo()
    {

    }

    void MethodThree()
    {

    }



    if (keyPressed == 'A' || keyPressed == 'a')
    {
        Console.WriteLine("Good");
    }
    else if (keyPressed == 'B' || keyPressed == 'b')
    {
        Console.WriteLine("Bad");
    }
    else
    {
        Console.WriteLine("Invalid choice");
    }
}



bool running = true;
while (running)
{
    Console.WriteLine("Still running");
    ConsoleKeyInfo choice = Console.ReadKey();
    if (choice.KeyChar == 'x')
    {
        running = false;
    }
}

running = true;

do
{
    Console.WriteLine("Still running");
    ConsoleKeyInfo choice = Console.ReadKey();
    if (choice.KeyChar == 'x')
    {
        running = false;
    }
} while (running);


int number;
bool isNotNumber = true;
while (isNotNumber)
{
    Console.WriteLine("Enter a number");
    string userInput = Console.ReadLine();
    if (int.TryParse(userInput, out number))
    {
        isNotNumber = false;
    }
    else
    {
        Console.WriteLine("Not a number");
    }
}











