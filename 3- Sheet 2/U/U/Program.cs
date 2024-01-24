namespace U
{
    internal class Program
    {
        public static void SomeSums(ushort n, byte a, byte b)
        {
            double Totalsum = 0;
            double sumOfDigits = 0;

            for (int i = 1; i <= n;  i++)
            {
                int num = i;
                for (int j = 0; j <= i.ToString().Length; j++)
                {
                    sumOfDigits += num % 10;
                    num /= 10;
                }

                if(sumOfDigits >= a && sumOfDigits <= b)
                    Totalsum += i;

                sumOfDigits = 0;
            }

            Console.WriteLine(Totalsum);
        }

        static void Main(string[] args)
        {
            string? input;
            ushort n;
            byte a, b;

            do
            {
                input = Console.ReadLine();
            }
            while (string.IsNullOrEmpty(input) || input.Split(" ").Length != 3
            || !ushort.TryParse(input.Split(" ")[0], out n)
            || !byte.TryParse(input.Split(" ")[1], out a)
            || !byte.TryParse(input.Split(" ")[2], out b)
            || n < 1 || a > b || a < 1 || a > 36 || b < 1 || b > 36);

            SomeSums(n, a, b);
        }
    }
}
