namespace Backend_intro;

public class CareProvider : IBookable
{
    public int Id { get; set; }
    public DateTime start { get; private set; }
    public DateTime end { get; private set; }
    public bool ScheduleTimeSlot(DateTime start, DateTime end)
    {
        this.start = start;
        this.end = end;
        return true;
    }

    public bool CancelTimeSlot()
    {
        throw new NotImplementedException();
    }
}