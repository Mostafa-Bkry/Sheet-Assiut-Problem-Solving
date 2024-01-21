namespace Y
{
    internal class Program
    {
        public static void Last2DigitsFromMul(ulong a, ulong b, ulong c, ulong d)
        {
            double mul = a % 100 * b % 100 * c % 100 * d % 100;
            //Console.WriteLine(a % 100);
            //Console.WriteLine(b % 100);
            //Console.WriteLine(c % 100);
            //Console.WriteLine(d % 100);
            Console.WriteLine($"{mul :0000.0}"); // if the mul = 0.0 the index 2 will not be found
            //Console.WriteLine($"{mul.ToString()[mul.ToString().Length - 2]}{mul.ToString()[mul.ToString().Length - 1]}");
            string[] result = string.Format($"{mul:0000.0}").Split('.');
            string r = result[0];

            Console.WriteLine($"{r[r.Length - 2]}{r[r.Length - 1]}");
        }

        static void Main(string[] args)
        {
            while (true)
            {
                string? input = Console.ReadLine();
                if (!string.IsNullOrEmpty(input) && input.Split(' ').Length == 4)
                {
                    string[] ab = input.Split(' ');
                    if (ulong.TryParse(ab[0], out ulong a) && ulong.TryParse(ab[1], out ulong b)
                        && ulong.TryParse(ab[2], out ulong c) && ulong.TryParse(ab[3], out ulong d))
                    {
                        Last2DigitsFromMul(a, b, c, d);
                        break;
                    }
                }
            }
        }
    }
}
