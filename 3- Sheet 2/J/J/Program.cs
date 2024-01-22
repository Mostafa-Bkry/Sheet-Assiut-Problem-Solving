namespace J
{
    internal class Program
    {
        public static void Primes(short n)
        {
            string primeNums = "2 ";

            for (int i = 3; i <= n; i++)
            {
                int check = 0, loops = 0;

                for (int j = 2; j < i; j++)
                {
                    loops++;
                    if ((i / (float)j) - (i / j) != 0)
                        check++;
                }
                if (check == loops)
                    primeNums += $"{i} ";
            }
            Console.WriteLine(primeNums);
        }

        static void Main(string[] args)
        {
            string? input;
            short n;
            do
            {
                input = Console.ReadLine();
            }
            while (string.IsNullOrEmpty(input) || !short.TryParse(input, out n) || n < 2 || n > 1000);

            Primes(n);
        }
    }
}