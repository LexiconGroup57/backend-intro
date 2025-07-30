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
}











