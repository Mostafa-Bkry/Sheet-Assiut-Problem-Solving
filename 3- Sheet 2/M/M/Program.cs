namespace M
{
    internal class Program
    {
        public static void LuckyNumbers(int a, int b)
        {
            int count = 0;
            string luckyNums = string.Empty;

            for(int i = a; i <= b; i++)
            {
                string s = i.ToString();
                for(int j = 0; j < s.Length; j++)
                {
                    if (s[j] == '4' || s[j] == '7')
                        count++;
                }
                if (s.Length == count)
                    luckyNums += $"{i} ";
                count = 0;
            }

            ////if i want to remove the last unwanted space from string luckyNums
            //Console.WriteLine(luckyNums.Length);
            //luckyNums = luckyNums.Trim();
            //Console.WriteLine(luckyNums.Length);

            if (string.IsNullOrEmpty(luckyNums))
                Console.WriteLine(-1);
            else
                Console.WriteLine(luckyNums);
        }

        static void Main(string[] args)
        {
            string? input;
            int a, b;
            do
            {
                input = Console.ReadLine();
            }
            while (string.IsNullOrEmpty(input) || input.Split(" ").Length != 2
            || !int.TryParse(input.Split(" ")[0], out a) || !int.TryParse(input.Split(" ")[1], out b));

            LuckyNumbers(a, b);
        }
    }
}
