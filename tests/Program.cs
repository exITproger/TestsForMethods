

public class Program
{
    static public int Sym(int x, int y)
    {
        return x + y;
    }
    //
    //
    //
    static public bool Prostoe(int number)
    {
        if (number <= 1) return false;
        if (number == 2) return true;
        if (number % 2 == 0) return false;

        for (int i = 3; i <= Math.Sqrt(number); i += 2)
        {
            if (number % i == 0)
                return false;
        }

        return true;
    }
    //
    //
    //
    private static void Main(string[] args)
    {
        int a = int.Parse(Console.ReadLine());
        int b = int.Parse(Console.ReadLine());
        int Symma = Sym(a, b);
        Console.WriteLine(Symma);



        Console.Write("Введите число: ");
        int num = int.Parse(Console.ReadLine());
        if (Prostoe(num))
            Console.WriteLine($"{num} - простое число");
        else
            Console.WriteLine($"{num} - не является простым числом");
    }
}