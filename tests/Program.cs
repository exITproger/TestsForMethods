

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
        int[] s = ComputeLPSArray("аабдааабдд");
        Console.WriteLine(String.Join(" ", s));
    }
    static int[] ComputeLPSArray(string pattern)
    {
        int[] lps = new int[pattern.Length];
        int len = 0;
        int i = 1;
        while (i < pattern.Length)
        {
            if (pattern[i] == pattern[len])
            {
                len++;
                lps[i] = len;
                i++;
            }
            else
            {
                if (len != 0)
                {
                    len = lps[len - 1];
                }
                else
                {
                    lps[i] = 0;
                    i++;
                }
            }
        }
        return lps;
    }
}