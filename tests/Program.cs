

public class Program
{
    static public int Factorial(int n)
    {
        if (n < 0)
            throw new ArgumentException("Factorial is not defined for negative numbers");

        if (n == 0)
            return 1;

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