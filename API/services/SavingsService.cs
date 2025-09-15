namespace API.services;

public class SavingsService : IFinanceService
{
    private IFinanceService _financeServiceImplementation;
    public decimal CalculateInterest(decimal amount, int years)
    {
        throw new NotImplementedException();
    }
}