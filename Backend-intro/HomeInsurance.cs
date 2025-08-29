namespace Backend_intro;

public class HomeInsurance : Insurance
{
    public decimal FireClaim()
    {
        base.Payment = 1000;
        decimal claim = Evaluation();
        return claim;
    }

    private decimal Evaluation()
    {
        return 0;
    }
}