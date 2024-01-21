namespace B
{
    internal class Program
    {
        public static void Checker(double a, double b, double k)
        {
            //string ak = string.Format($"{(a / k) - (ulong)(a / k):0.0}");
            //string bk = string.Format($"{(b / k) - (ulong)(b / k):0.0}");
            //Console.WriteLine(ak);
            //Console.WriteLine(bk);

            if (a % k == 0 && b % k == 0)
                Console.WriteLine("Both");
            else if (a % k == 0 && b % k != 0)
                Console.WriteLine("Memo");
            else if (a % k != 0 && b % k == 0)
                Console.WriteLine("Momo");
            else
                Console.WriteLine("No One");
        }

        static void Main(string[] args)
        {
            string? input;
            double a, b, k;

            while (true)
            {
                input = Console.ReadLine();
                if (!string.IsNullOrEmpty(input) && input.Split(" ").Length == 3)
                {
                    string[] abk = input.Split(" ");
                    if (double.TryParse(abk[0], out a) && double.TryParse(abk[1], out b) && double.TryParse(abk[2], out k)
                        && !(a < 1) && !(b < 1) && !(k < 1))
                        break;
                }
            }

            Checker(a, b, k);
        }
    }
}
