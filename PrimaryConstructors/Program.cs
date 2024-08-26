namespace PrimaryConstructors;

public class Program
{
    static void Main(string[] args)
    {
        var demo = new PrimaryConstructors("Paul");
        Console.WriteLine(demo.Name);
    }
}

public class PrimaryConstructors(string name)
{
    public string Name = name.ToUpper();
}


public class TraditionalClass
{
    public string Name { get; set; }
    public TraditionalClass(string name)
    {
        Name = name;
    }
}