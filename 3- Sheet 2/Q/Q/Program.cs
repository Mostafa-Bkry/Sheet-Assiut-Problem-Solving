namespace Q
{
    internal class Program
    {
        public static void FromRtoL(uint n)
        {
            #region Another Way
            //while (n > 0)
            //{
            //    if(n.ToString().Length > 1)
            //    {
            //        Console.Write($"{n % 10} ");
            //        n /= 10;
            //        continue;
            //    }
            //    Console.Write($"{n % 10}");
            //    n /= 10;
            //} 
            #endregion

            while (true)
            {
                if (n.ToString().Length == 1)
                {
                    Console.Write($"{n % 10}");
                    break;
                }
                Console.Write($"{n % 10} ");
                n /= 10;
            }
            Console.WriteLine();
        }

        static void Main(string[] args)
        {
            string? numOfTestCases, caseX;
            byte check;

            do
            {
                numOfTestCases = Console.ReadLine();
            }
            while (string.IsNullOrEmpty(numOfTestCases) || !byte.TryParse(numOfTestCases, out check) || check < 1 || check > 10);

            while ( check > 0)
            {
                caseX = Console.ReadLine();
                if(!string.IsNullOrEmpty(caseX) && uint.TryParse(caseX, out uint num))
                {
                    FromRtoL(num);
                    check--;
                }
            }
        }
    }
}
