namespace Backend_intro;

public class Presentation
{
    public static void WriteLineDemo()
    {
        Console.WriteLine("Hello, World!");             // Intro line?

        Console.Clear();
        Console.Write("25 + ");
        Console.Write("10 = ");
        Console.WriteLine(35);
        Console.WriteLine("A new line");
    }

    public void EvaluationDemo()
    {
        int interestRate = 5;

        int result = interestRate * 12;

        int x = 23;
        int prognosis = x + 4;
        int actual = 34 - 4 + 0;

        Console.WriteLine(!(prognosis > actual));
    }
}