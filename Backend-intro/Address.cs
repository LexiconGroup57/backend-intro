namespace Backend_intro;

public class Address : IComparable
{
    public int Id { get; set; }
    public string City { get; set; }
    
    
    public int CompareTo(object? obj)
    {
        throw new NotImplementedException();
    }
}