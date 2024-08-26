namespace DefiningArrays;

public static class Constants
{
    public const int MAXSIZE = 10;
}
public class Program
{
    static void Main(string[] args)
    {
        //int[] numbers = { 1, 2, 3, 4, 5 };
        var numbers = new Numbers(); // { 1, 2, 3, 4, 5 };
        string result = string.Join(", ", numbers);
        Console.WriteLine(result);


        var items = new Items();

        for (int i = 0; i < Constants.MAXSIZE; i++)
        {
            items[i] = "something " + i;
        }
        Console.WriteLine(string.Join(", ", items));
    }
}

[System.Runtime.CompilerServices.InlineArray(Constants.MAXSIZE)]
public struct Items
{
    private string _name;
}

public struct Numbers
{
    private int _number;
}