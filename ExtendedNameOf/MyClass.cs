namespace ExtendedNameOf;

public class MyClass
{
    [Name(nameof(text)]
    public void Test(string text)
    {
        [Name(nameof(T))]
        void LocalFunction<T>(T param)
        { 
        }

        [Name(nameof(T))]

        void LocalFunction<T>(T param)
        { 
        }

        var lambdaExpression = 
            ([Name(nameof(aNumber))] int aNumber) => aNumber.ToString();

    }
}

//public class NameAttribute : Attribute { }
