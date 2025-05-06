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
public static class PalindromeChecker
{
    // Проверяет, является ли строка палиндромом
    public static bool IsPalindrome(string input)
    {
        if (string.IsNullOrEmpty(input))
            return false;

        string cleaned = new string(input
            .Where(c => !char.IsPunctuation(c) && !char.IsWhiteSpace(c))
            .Select(char.ToLower)
            .ToArray());

        return cleaned.SequenceEqual(cleaned.Reverse());
    }

    // Проверяет, все ли строки в массиве — палиндромы
    public static bool AreAllPalindromes(string[] inputs)
    {
        if (inputs == null || inputs.Length == 0)
            return false;

        return inputs.All(IsPalindrome);
    }

    // Расширенная проверка (числа, даты и другие объекты, преобразованные в строку)
    public static bool IsPalindromeObject(object obj)
    {
        return IsPalindrome(obj?.ToString() ?? "");
    }
}

public class Program
{
    static public bool Prostoe(int number)
    {
        if (number <= 1) return false;
        if (number == 2) return true;
        if (number % 2 == 0) return false;

        for (int i = 3; i <= Math.Sqrt(number)+1; i += 2)
        {
            if (number % i == 0)
                return false;
        }

        return true;
    }
    static public int Factorial(int n)
    {
        // Обработка отрицательных чисел
        if (n < 0)
            throw new ArgumentException("Factorial is not defined for negative numbers");

        // Базовый случай рекурсии
        if (n == 0)
            return 1;

        // Проверка на переполнение перед вычислением
        checked
        {
            try
            {
                return n * Factorial(n - 1);
            }
            catch (OverflowException)
            {
                throw new OverflowException($"Factorial exceeds int.MaxValue for n > 20");
            }
        }
    }
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