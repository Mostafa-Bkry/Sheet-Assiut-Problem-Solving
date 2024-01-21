namespace I
{
    internal class Program
    {
        public static void LuckyOrNot(byte n)
        {
            //Console.WriteLine(n % 10);
            //Console.WriteLine((byte)(n * 0.1));

            if ((n >= 0 && n < 10) || n >= 100)
                Console.WriteLine("NO");
            else
            {
                byte fDigit = (byte)(n % 10);  //ones
                byte sDigit = (byte)(n * 0.1); //tens

                //if (fDigit == 0)
                //    Console.WriteLine("NO");
                if (fDigit / (float)sDigit - fDigit / sDigit == 0 || sDigit / (float)fDigit - sDigit / fDigit == 0)
                    Console.WriteLine("YES");
                else
                    Console.WriteLine("NO");
            }
        }

        static void Main(string[] args)
        {
            while (true)
            {
                string? input = Console.ReadLine();
                if (!string.IsNullOrEmpty(input) && byte.TryParse(input, out byte n))
                {
                    LuckyOrNot(n);
                    break;
                }
            }
        }
    }
}
