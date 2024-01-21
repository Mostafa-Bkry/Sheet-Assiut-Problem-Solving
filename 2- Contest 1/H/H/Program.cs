using System.Numerics;

namespace H
{
    internal class Program
    {
        public static void CheckDataType(decimal n, decimal k, decimal a)
        {
            //(n * k) / a

            Console.WriteLine(n * k);
            decimal equ = n * k / a;
            Console.WriteLine(equ);

            if (equ - (long)equ == 0)
                if (equ > 2147483647)
                    Console.WriteLine("long long");
                else
                    Console.WriteLine("int");
            else
                Console.WriteLine("double");
        }

        static void Main(string[] args)
        {
            while (true)
            {
                string? input = Console.ReadLine();
                if (!string.IsNullOrEmpty(input) && input.Split(" ").Length == 3)
                {
                    string[] ab = input.Split(" ");
                    if (uint.TryParse(ab[0], out uint b) && uint.TryParse(ab[1], out uint c)
                        && uint.TryParse(ab[2], out uint a))
                    {
                        if (a > 0 && b > 0 && c > 0)
                        {
                            CheckDataType(b, c, a);
                            break;
                        }
                    }
                }
            }
        }
    }
}
