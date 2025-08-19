namespace Backend_intro;

public class Hammer
{
    public static int ReturnNumber(int numberToDivideWith) 
    {
        int division = 3;

        try
        {
            division = 23 / numberToDivideWith;
        }

        finally
        {
            Console.WriteLine("This will run regardless");
        }

        return division;
    }
}