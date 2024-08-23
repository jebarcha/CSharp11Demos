using System.Diagnostics.CodeAnalysis;
using System.Numerics;

namespace DemoCS11;

internal class Person
{
    public Person() { }
    
    public required string? Name { get; init; }
    
    [SetsRequiredMembers]
    public Person(string name)
    {
        Name = name;
    }

    public int GetValue()
    {
        var utils = new PersonUtils();
        return utils.GetValue;
    }

    [MyAttribute<string>(nameof(myParam), "Jose")]
    public void MethodWithParams(string myParam)
    {

    }

    [MyAttribute<int>(nameof(myParam), 42)]
    public void MethodWithParamsInt(string myParam)
    {

    }
}

// Example 6: Access Modifier
// we are hidding this class to see it only on this file.
// file is a new Access Modifier
file class PersonUtils
{
    public int GetValue => 42;
}


// Example 8: Increased sope of nameof
file class MyAttribute<T> : Attribute
{
    public string Param { get; set; }
    public T GenericValue { get; set; }
    public MyAttribute(string param, T genericValue)
    {
        Param = param;
        GenericValue = genericValue;
    }
}

public class GenericMath
{
    public static TResult Sum<T, TResult>(IEnumerable<T> values)
        where T: INumberBase<T>
        where TResult: INumberBase<TResult>
    {
        TResult result = TResult.Zero;

        foreach (var value in values)
        {
            result += TResult.CreateChecked(value);
        }
        return result;
    }
}
