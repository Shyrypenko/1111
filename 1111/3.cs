public interface ICalc2
{
    int CountDistinct();
    int EqualToValue(int valueToCompare);
}

public class Array : ICalc2
{
    private int[] data;

    public Array(int[] data)
    {
        this.data = data;
    }

    public int CountDistinct()
    {
        return data.Distinct().Count();
    }

    public int EqualToValue(int valueToCompare)
    {
        int count = 0;
        foreach (var value in data)
            if (value == valueToCompare) count++;
        return count;
    }
}