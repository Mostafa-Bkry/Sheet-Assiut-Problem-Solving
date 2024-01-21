namespace F
{
    internal class Program
    {
        public static void MulTable(short _n)
        {
            for(int i = 1; i <= 12; i++)
                Console.WriteLine($"{_n} * {i} = {_n * i}");
        }

        static void Main(string[] args)
        {
            string? numOfValues;
            byte n;

            do
            {
                numOfValues = Console.ReadLine();
            }
            while (string.IsNullOrEmpty(numOfValues) || !byte.TryParse(numOfValues, out n) || n < 1 || n > 50);

            MulTable(n);
        }
    }
}
