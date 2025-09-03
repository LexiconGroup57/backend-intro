// See https://aka.ms/new-console-template for more information
// 

using Backend_intro;

List<string> someWordsToo = new List<string>() { "Ball", "Apple", "Coffin", "Apple"};
List<string> someWordsMoreToo = new List<string>() { "Fruit", "Orange", "Coffin"};

List<string> concatWords = someWordsToo.Concat(someWordsMoreToo).ToList();
List<string> exceptWords = someWordsToo.Except(someWordsMoreToo).ToList();
List<string> intersectWords = someWordsToo.Intersect(someWordsMoreToo).ToList();
List<string> unionWords = someWordsToo.Union(someWordsMoreToo).ToList();

foreach (string word in unionWords)
{
    Console.Write(word + ", ");
}

Console.ReadLine();



List<string> someWords = new List<string>() { "Ball", "Apple", "Coffin", "Apple"};
List<string> someWordsMore = new List<string>() { "Fruit", "Orange", "Coffin"};

someWordsMore.Reverse();

List<string> distinctWords = someWords.Distinct().ToList();
List<string> orderedWords = someWords.Order().ToList();


foreach (string word in someWordsMore)
{
    Console.Write(word + ", ");
}

Console.ReadLine();

List<int> numbersLinq = new List<int>() { 4 , 7 , 2 , 1 , 6 , 3 , 5 };

int sumLinq = numbersLinq.Sum();
double averageLinq = numbersLinq.Average();
int maxLinq = numbersLinq.Max();

Console.WriteLine(sumLinq);
Console.WriteLine(averageLinq);
Console.WriteLine(maxLinq);

Console.ReadLine();



string snippet =
    "This type parameter is covariant. That is, you can use either the type you specified or any type that is more derived. For more information about covariance and contravariance, see Covariance and Contravariance in Generics.";
string[] wordsFromSnippet = snippet.Split(' ');

List<string> newWords = wordsFromSnippet
    .Where(word => word.Length > 6)
    .Select(word => word + " is longer than six letters")
    .Select(word => word.ToUpper())
    .ToList();

List<Person> people = new List<Person>();
List<int> newPeople = people
    .Where(person => person.Age > 20)
    .Select(person => person.Age)
    .ToList();

// string resultant = LastMethod(NextToLast(FirstMethod("Goo")));

List<Person> peopleList = new List<Person>();

foreach (Person person in people)
{
    if (person.Age > 20) peopleList.Add(person);
}


foreach (string word in newWords)
{
    Console.WriteLine(word);
}


Console.ReadLine();





Address address = new Address();
Event newEvent = new Event("ff", "ee");
Char newChar = 'a';
List<IComparable> list = new List<IComparable>();
list.Add(newEvent);
list.Add(newChar);
list.Add(address);


HomeInsurance homeInsurance = new HomeInsurance();

CarInsurance carInsurance = new CarInsurance();

List<Insurance> insurances = new List<Insurance>();
insurances.Add(homeInsurance);
insurances.Add(carInsurance);
decimal value = 0;
int e = 1;
if (insurances[e] is CarInsurance)
{
    value = (insurances[e] as CarInsurance).AccidentClaim();
    // value = insurances[e].AccidentClaim();
}


Console.WriteLine(value);

Console.ReadLine();

Impact impact = new Impact(34, 99);
int x = impact.CoordinateX;

//impact.CoordinateX = 23;
// code
// impact.CoordinateY = 45;
impact.ChangeCoordinates(23, 45);


using (StreamWriter writer = new StreamWriter("FileAdress.txt"))
{
    writer.WriteLine("This line is for testing");
}

try
{
    using StreamReader reader = new StreamReader("FileAdress.txt");

    string result = reader.ReadToEnd();

    Console.WriteLine(result);
}
catch (IOException ex)
{
    Console.WriteLine(ex.Message);
}

Console.ReadLine();

int division = 2;


try
{
    division = Hammer.ReturnNumber(0);
}
catch (DivideByZeroException ex)
{
    Console.WriteLine(ex.Message);
    Console.WriteLine(ex.StackTrace);
    Console.WriteLine(ex.Source);
}

Console.WriteLine(division);

Console.ReadLine();


Random chanceObject = new Random();
double rand = chanceObject.NextSingle();
int randInt = chanceObject.Next(20, 100);


Console.WriteLine(rand);

Console.ReadLine();

string[] names = { "Kjetil", "Anna", "Pete" };

List<string> namesList = new List<string>();
namesList.Add("Kjetil");
bool nameWasInList = namesList.Remove("Anna");

Console.WriteLine(nameWasInList);

Console.ReadLine();

Person employee = new Person();

employee.Name = "Kjetil";
string name = employee.Name;
employee.Name = "Anna";
employee.Mood = "Sad";

Console.WriteLine(name);

Console.ReadLine();

string textValue = "Returns a value indicating whether a specified character occurs within this string.";

string[] anotherArray = textValue.Split(' ');
string CsvList = String.Join(",", anotherArray); 

string[] words = textValue.Split("whether a specified ");
bool isCharacter = words[1].Contains("occurs");

int startsAt = words[1].IndexOf("occurs");
int endsAt = startsAt + "occurs".Length - 1;
string lastWord = words[1];
char letterAtEnd = lastWord[endsAt];


Char letterToWrite = textValue[0]; 
int valueToWrite = textValue.Length;

for (int i = 0; i < words.Length; i++)
{
    Console.WriteLine(words[i]); 
}
if(isCharacter) Console.WriteLine(CsvList);

Console.ReadLine();


string[] texts = { "Hello", "World" };
int[] numbers = new int[3];

numbers[1] = 23;
numbers[0] = 46;
numbers[2] = 69;


Console.WriteLine(texts[0]);  // Hello?

double[] newNumbers = new double[28];  

Console.WriteLine(newNumbers.Length);

Console.ReadLine();

int itemsRemoved = 6;
int upperBound = newNumbers.Length - itemsRemoved;

for (int i = 0; i < newNumbers.Length; i++)
{
    newNumbers[i] = 0.3566 + i;
}

for (int i = 0; i < upperBound; i++)
{
    Console.Write(newNumbers[i] + " ");  
}

Console.WriteLine();

Console.WriteLine(newNumbers[27]);

Console.ReadLine();

Presentation.WriteLineDemo();
Presentation demo = new Presentation();
demo.EvaluationDemo();

Person kjetil = new Person();
Person anna = new Person();
Person pete = new Person();

if(String.Equals("foo", "high")) Console.WriteLine("Hello");
string newText = "Hello";
int length = newText.Length;
bool equals = newText.Equals("foo");

Person.GetAge(2002);

Hammer hammerBrand = new Hammer();

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











