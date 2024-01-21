using System.Runtime.InteropServices;

namespace D
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string? numOfValues;

            while (true)
            {
                numOfValues = Console.ReadLine();
                if (!string.IsNullOrEmpty(numOfValues) && short.TryParse(numOfValues, out short n) && n >= 1000 && n <= 10000 - 1)
                {
                    if (n == 1999)
                    {
                        Console.WriteLine("Correct");
                        break;
                    }
                    Console.WriteLine("Wrong");
                }
            }
        }
    }
}
