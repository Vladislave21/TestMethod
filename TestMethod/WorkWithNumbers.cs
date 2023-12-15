namespace TestMethod;

public class WorkWithNumbers
{
    public static List<int> IncrementValues(List<int> oldValues)
    {
        List<int> values = new List<int>();
        values.AddRange(oldValues);
        for (int i = 0; i < values.Count; i++)
            values[i] += 10;

        return values;
    }
}
