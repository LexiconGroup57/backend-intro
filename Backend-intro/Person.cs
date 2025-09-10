namespace Backend_intro;

public class Person
{

    /*private string name;

    public void SetName(string name)
    {
        if(name.Length < 3) throw new ArgumentException("Name is too short");
        this.name = name;
    }

    public string GetName()
    {
        return name;
    }*/

    public string Name { get; set; }
    public int Age { get; set; }
    public string Mood { get; set; }
    public Address Address { get; set; }
    
    public Person()
    {
    }

    public Person (string name, int age)
    {
        Name = name;
        Age = age;
    }
 
    public static int GetAge(int yearBorn )
    {
        Console.WriteLine("Debugging purpose: " + yearBorn);
        return 2025 - yearBorn;
    }
}