namespace L
{
    internal class Program
    {
        //greatest common divisor
        public static void GCD(short a, short b)
        {
            short smallest = a <= b ? a : b;
            double gcd = 0;
            for (int i = 1; i <= smallest; i++)
            {
                if ((a / (double)i) - (a / i) == 0 && (b / (double)i) - (b / i) == 0)
                    gcd = gcd < i ? i : gcd;
            }
            Console.WriteLine(gcd);
        }

        static void Main(string[] args)
        {
            string? input;
            short a, b;
            do
            {
                input = Console.ReadLine();
            }
            while (string.IsNullOrEmpty(input) || input.Split(" ").Length != 2
            || !short.TryParse(input.Split(" ")[0], out a) || !short.TryParse(input.Split(" ")[1], out b));

            GCD(a, b);
        }
    }
}
