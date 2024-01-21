using System.ComponentModel.DataAnnotations;

namespace K
{
    internal class Program
    {
        public static void MinANdMax(int a, int b, int c)
        {
            if (a >= b && a >= c)
                if (b >= c)
                    Console.WriteLine($"{c} {a}");
                else
                    Console.WriteLine($"{b} {a}");
            else if (b >= a && b >= c)
                if (a >= c)
                    Console.WriteLine($"{c} {b}");
                else
                    Console.WriteLine($"{a} {b}");
            else
                if (a >= b)
                    Console.WriteLine($"{b} {c}");
                else
                    Console.WriteLine($"{a} {c}");
        }

        static void Main(string[] args)
        {
            while (true)
            {
                string? input = Console.ReadLine();
                if (!string.IsNullOrEmpty(input) && input.Split(' ').Length == 3)
                {
                    string[] ab = input.Split(' ');
                    if (int.TryParse(ab[0], out int a) && int.TryParse(ab[1], out int b) && int.TryParse(ab[2], out int c))
                    {
                        MinANdMax(a, b, c);
                        break;
                    }
                }
            }
        }
    }
}
