namespace DefaultLambdaParams;

public class Program
{
    static void Main(string[] args)
    {
        var mul = (double a, double b = 10) => a * b;

        Console.WriteLine(mul(1));
    }
}
