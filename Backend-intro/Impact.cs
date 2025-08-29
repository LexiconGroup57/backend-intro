namespace Backend_intro;

public class Impact
{
    public int CoordinateX { get; private set; }
    public int CoordinateY { get; private set; }
    public List<Event> Events { get; private set; }
    public DateTime DateTime { get; set; }

    public Impact(int x, int y)
    {
        CoordinateX = x;
        CoordinateY = y;
        Events = new List<Event>();
    }
    
    public void ChangeCoordinates(int x, int y)
    {
        CoordinateX = x;
        CoordinateY = y;
    }

    public void AddEvent(Event e)
    {
        Events.Add(e);
        
    }
    
    public void AddEvent(string name, string description)
    {
        Events.Add(new Event(name, description));
    }
}