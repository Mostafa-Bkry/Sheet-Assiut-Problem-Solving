namespace D
{
    internal class Program
    {
        public static void SolvePuzzel(long a, long b, long c, long d)
        {
            if(a + b - c == d)
                Console.WriteLine("YES");
            else if (a + b * c == d)
                Console.WriteLine("YES");
            else if (a - b + c == d)
                Console.WriteLine("YES");
            else if (a - b * c == d)
                Console.WriteLine("YES");
            else if (a * b + c == d)
                Console.WriteLine("YES");
            else if (a * b - c == d)
                Console.WriteLine("YES");
            else
                Console.WriteLine("NO");
        }
        static void Main(string[] args)
        {
            while (true)
            {
                string? input = Console.ReadLine();
                if (!string.IsNullOrEmpty(input) || input.Split(' ').Length == 4)
                {
                    string[] ab = input.Split(' ');
                    if (long.TryParse(ab[0], out long a) && long.TryParse(ab[1], out long b)
                        && long.TryParse(ab[2], out long c) && long.TryParse(ab[3], out long d))
                    {
                        SolvePuzzel(a, b, c, d);
                        break;
                    }
                }
            }
        }
    }
}
