namespace W
{
    internal class Program
    {
        public static void Diamond(byte n)
        {
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    if (j >= n - i - 1)
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

            for (int l = 0; l < n; l++)
            {
                for (int o = 0; o < n; o++)
                {
                    if(o <= l - 1)
                    {
                        Console.Write(' ');
                        continue;
                    }
                    Console.Write('*');
                }

                for (int b = 1; b < n; b++)
                {
                    if (b >= n - l)
                        break;
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
            
            Diamond(n);
        }
    }
}
