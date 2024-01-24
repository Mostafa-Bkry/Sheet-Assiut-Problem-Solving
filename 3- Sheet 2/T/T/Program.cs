namespace T
{
    internal class Program
    {
        public static void FullPyramid(byte _n)
        {
            for (int i = 0; i < _n; i++)
            {
                for (int j = 0; j < _n; j++)
                {
                    if (j >= _n - i - 1)
                    {
                        Console.Write('*');
                        continue;
                    }
                    Console.Write(' ');
                }

                for (int k = 1; k <= i; k++)
                {
                    Console.Write('*');
                }

                Console.WriteLine();
            }
        }

        static void Main(string[] args)
        {
            string? input;
            byte n;
            do
            {
                input = Console.ReadLine();
            } while (string.IsNullOrEmpty(input) || !byte.TryParse(input, out n) || n < 1 || n > 99);

            FullPyramid(n);
        }
    }
}
