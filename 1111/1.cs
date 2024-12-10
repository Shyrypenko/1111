using System;
using System.Linq;

public interface ICalc
{
    int Less(int valueToCompare);
    int Greater(int valueToCompare);
}

public class Array : ICalc
{
    private int[] data;

    public Array(int[] data)
    {
        this.data = data;
    }

    public int Less(int valueToCompare) =>
        data.Count(value => value < valueToCompare);

    public int Greater(int valueToCompare) =>
        data.Count(value => value > valueToCompare);
}

class Program
{
    static void TestICalc()
    {
        int[] values = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
        Array array = new Array(values);

        Console.WriteLine("Values less than 5: " + array.Less(5));
        Console.WriteLine("Values greater than 5: " + array.Greater(5));
    }
}