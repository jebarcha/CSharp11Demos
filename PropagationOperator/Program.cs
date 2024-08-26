namespace PropagationOperator;

public class Program
{
    static void Main(string[] args)
    {
        string[] songs1 = ["One", "Two"];
        string[] songs2 = ["Three", "Four"];
        string[] songs3 = ["Five", "Six"];

        string[] songs = [.. songs1, .. songs3, .. songs2];
        Console.WriteLine(string.Join(", ", songs));
    }
}
