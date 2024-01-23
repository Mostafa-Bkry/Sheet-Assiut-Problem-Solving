namespace O
{
    internal class Program
    {
        public static void Pyramid(byte _n)
        {
            for (int i = 0; i < _n; i++)
            {
                for (int j = 0; j <= i; j++)
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

            Pyramid(n);
        }
    }
}
