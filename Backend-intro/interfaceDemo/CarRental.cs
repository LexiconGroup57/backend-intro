namespace Backend_intro;

public class CarRental : IBookable, IPayable
{
    public DateTime Start { get; set; }
    public DateTime End { get; set; }
    public bool Booked { get; set; }
    public bool ScheduleTimeSlot(DateTime start, DateTime end)
    {
        if(start > end) return false;
        Start = start;
        End = end;
        Booked = true;
        return true;
    }

    public bool CancelTimeSlot()
    {
        if (Booked == true)
        {
            Booked = false;
            return true;
        }
        return false;
    }

    public decimal AmountToPay()
    {
        throw new NotImplementedException();
    }
    
}