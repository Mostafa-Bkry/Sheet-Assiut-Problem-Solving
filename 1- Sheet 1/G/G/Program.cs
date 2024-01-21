using System.Diagnostics;

namespace G
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Stopwatch stopwatch = new Stopwatch();
            ulong n, sum = 0;
            while (!ulong.TryParse(Console.ReadLine(), out n));
            stopwatch.Start();
            for (ulong i = 1; i <= n; i++)
            {
                sum += i;
            }
            Console.WriteLine(sum);
            stopwatch.Stop();
            Console.WriteLine(stopwatch.Elapsed.TotalSeconds);
        }
    }
}
