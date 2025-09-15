namespace API.services;

public interface IFinanceService
{
    decimal CalculateInterest(decimal amount, int years);
}