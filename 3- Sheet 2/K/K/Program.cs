namespace K
{
    internal class Program
    {
        public static void Divisors(short _n)
        {
            for (int i = 1; i <= _n; i++)
            {
                //Console.WriteLine((_n / (double)i) - (_n / i));
                if ((_n / (double)i) - (_n / i) == 0)
                    Console.WriteLine(i);
            }
        }

        static void Main(string[] args)
        {
            string? input;
            short n;
            do
            {
                input = Console.ReadLine();
            }
            while (string.IsNullOrEmpty(input) || !short.TryParse(input, out n));

            Divisors(n);
        }
    }
}
