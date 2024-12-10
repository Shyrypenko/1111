public interface IOutput2
{
    void ShowEven(); // Display even numbers
    void ShowOdd();  // Display odd numbers
}

public class Array : IOutput2
{
    private int[] data;

    public Array(int[] data)
    {
        this.data = data;
    }

    public void ShowEven()
    {
        foreach (var value in data)
            if (value % 2 == 0) Console.Write(value + " ");
        Console.WriteLine();
    }

    public void ShowOdd()
    {
        foreach (var value in data)
            if (value % 2 != 0) Console.Write(value + " ");
        Console.WriteLine();
    }
}