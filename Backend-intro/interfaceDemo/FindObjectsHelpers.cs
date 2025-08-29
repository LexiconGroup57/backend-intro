namespace Backend_intro;

public class FindObjectsHelpers : IFindObjectsHelpers
{
    
    public decimal GetSomething(int number, string clause, bool wantObject)
    {
        return 23;
    }

    public decimal GetSomething(int number, string clause)
    {
        throw new NotImplementedException();
    }
}