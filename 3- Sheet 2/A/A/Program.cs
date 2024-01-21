namespace A
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string? input;
            short n;

            do
            {
                input = Console.ReadLine();
            }
            while (string.IsNullOrEmpty(input) || !short.TryParse(input, out n) || n < 1 || n > 1000);

            for(int i = 1; i <= n; i++)
                Console.WriteLine(i);
        }
    }
}
