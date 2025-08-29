namespace Backend_intro;

public interface IBookable
{
    // bool to indicate if action was success
    bool ScheduleTimeSlot(DateTime start, DateTime end);
    bool CancelTimeSlot();
}