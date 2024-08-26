using Person = System.Collections.Generic.Dictionary<string, object>;
using Point = (int x, int y);
using Item = (string name, decimal price);

namespace AliasAnyType;

public class Program
{
    static void Main(string[] args)
    {
        Item item = new Item() { name = "something", price = 10 };
        Console.WriteLine(item.name);

        Person person = new Person();
        person["Name"] = "Alice";
        person["Age"] = 25;
        Console.WriteLine(person["Name"]);

        Point point = (1, 2);
        Console.WriteLine(point.x); // 1
        Console.WriteLine(point.y); // 2
    }
}
