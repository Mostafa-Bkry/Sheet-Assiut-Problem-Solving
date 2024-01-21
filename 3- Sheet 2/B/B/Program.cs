namespace B
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

            //bool noEvenNums = false;
            if(n == 1)
                Console.WriteLine(-1);
            else
            {
                for (int i = 1; i <= n; i++)
                {
                    if (i % 2 == 0)
                    {
                        Console.WriteLine(i);
                        //noEvenNums = true;
                    }
                }
            }

            //if (!noEvenNums)
            //    Console.WriteLine(-1);
        }
    }
}
