namespace Backend_intro;

public class Demo
{
    private readonly IPayable _payable;
    private readonly IBookable _bookable;
    public Demo()
    {
        _payable = new CarRental();
        _bookable = new CareProvider();
    }

    public void CastInterfaces()
    {
        _payable.AmountToPay();
        (_payable as CarRental).ScheduleTimeSlot(DateTime.Now, DateTime.Now.AddDays(1));
        
        CarRental carRental = new CarRental();
        
       // decimal amount = carRental.AmountToPay();
        
        decimal amount2 = _payable.AmountToPay();
    }
}