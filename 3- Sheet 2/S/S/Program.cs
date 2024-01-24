namespace S
{
    internal class Program
    {
        public static void SumOfOdds(ushort x, ushort y)
        {
            ushort biggest = x >= y ? x : y;
            ushort smallest = x >= y ? y : x;
            double sum = 0;

            for (int i = smallest + 1; i < biggest; i++)
            {
                if ((float)i % 2 != 0)
                    sum += i;
            }
            Console.WriteLine(sum);
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

            while (check > 0)
            {
                caseX = Console.ReadLine();

                if (!string.IsNullOrEmpty(caseX) && caseX.Split(" ").Length == 2
                    && ushort.TryParse(caseX.Split(" ")[0], out ushort x)
                    && ushort.TryParse(caseX.Split(" ")[1], out ushort y))
                {
                    SumOfOdds(x, y);
                    check--;
                }
            }
        }
    }
}
