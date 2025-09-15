namespace API.services;

public class FinanceService : IFinanceService
{
    private IFinanceService _financeServiceImplementation;

    public decimal CalculateInterestRate(decimal amount, int years)
    {
        throw new NotImplementedException();
    }

    public decimal CalculateInterest(decimal amount, int years)
    {
        throw new NotImplementedException();
    }
}