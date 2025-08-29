namespace Backend_intro;

public class CarInsurance : Insurance
{
    public decimal ThirdPartyClaim()
    {
        return 700;
    }
    
    public decimal AccidentClaim()
    {
        return 89;
    }
}