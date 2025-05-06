public static class ComparisonUtils
{
    public static T Max<T>(T first, T second) where T : IComparable<T>
    {
        return first.CompareTo(second) >= 0 ? first : second;
    }

    public static T Max<T>(params T[] values) where T : IComparable<T>
    {
        if (values == null || values.Length == 0)
            throw new ArgumentException("At least one value must be provided");

        T max = values[0];
        for (int i = 1; i < values.Length; i++)
        {
            if (values[i].CompareTo(max) > 0)
                max = values[i];
        }
        return max;
    }
}

public class Program
{
    static public int Sym(int x, int y)
    {
        return x + y;
    }
    private static void Main(string[] args)
    {
        int a = int.Parse(Console.ReadLine());
        int b = int.Parse(Console.ReadLine());
        int Symma = Sym(a, b);
        Console.WriteLine(Symma);
    }
    
}