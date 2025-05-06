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