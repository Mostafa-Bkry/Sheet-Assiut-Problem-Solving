namespace R
{
    internal class Program
    {
        public static void CalcAge(uint n)
        {
            uint years = n / 365;
            n -= 365 * years;
            uint months = n / 30;
            n -= 30 * months;
            uint days = n;
            Console.WriteLine($"{years} years");
            Console.WriteLine($"{months} months");
            Console.WriteLine($"{days} days");
        }
        static void Main(string[] args)
        {
            uint result;
            while (!uint.TryParse(Console.ReadLine(), out result)) ;
            CalcAge(result);
        }
    }
}
