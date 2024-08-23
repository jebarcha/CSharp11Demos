using System.Numerics;

//int[] numbers = new[] { 1, 2, 3, 4, 5 };
//var sum = AddAll(numbers);
//Console.WriteLine(sum);

//double[] numbersD = new[] { 1, 2, 3, 4, 5, 0.69 };
//var sumD = AddAllD(numbersD);
//Console.WriteLine(sumD);

double[] numbersD = new[] { 1, 2, 3, 4, 5, 0.69 };
var sumG = AddAllGen(numbersD);
Console.WriteLine(sumG);

T AddAllGen<T>(T[] values) where  T: INumber<T>
{
    T result = T.Zero;

    foreach (var value in values)
    {
        result += value;
    }

    return result;
}



//int AddAll(int[] numbers)
//{
//    int result = 0;

//    foreach (int number in numbers)
//    {
//        result += number;
//    }

//    return result;
//}

//double AddAllD(double[] numbers)
//{
//    double result = 0;

//    foreach (double number in numbers)
//    {
//        result += number;
//    }

//    return result;
//}