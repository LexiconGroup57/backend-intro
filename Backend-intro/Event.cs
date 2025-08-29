namespace Backend_intro;

public class Event : IComparable
{
    public string Description { get; set; }
    public int Id { get; set; }
    public string Name { get; set; }

    public Event(string name, string description)
    {
        Name = name;
        Description = description;
    }

    public int CompareTo(object? obj)
    {
        throw new NotImplementedException();
    }
}