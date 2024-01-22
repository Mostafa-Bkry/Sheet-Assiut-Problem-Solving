namespace N
{
    internal class Program
    {
        public static void NumbersHistogram(string _symbol, byte[] _numsArr)
        {
            for (int i = 0;  i < _numsArr.Length; i++)
            {
                for(int j = 0; j < _numsArr[i]; j++)
                {
                    Console.Write(_symbol);
                }
                Console.WriteLine();
            }
        }

        static void Main(string[] args)
        {
            string? symbol, numOfLines, nums;
            byte lines;
            do
            {
                symbol = Console.ReadLine();
            }
            while (string.IsNullOrEmpty(symbol) || (symbol != "+" && symbol != "-" && symbol != "*" && symbol != "/"));

            do
            {
                numOfLines = Console.ReadLine();
            }
            while (string.IsNullOrEmpty(symbol) || !byte.TryParse(numOfLines, out lines));

            byte[] numsArr = new byte[lines];

            while (true)
            {
                nums = Console.ReadLine();
                if(!string.IsNullOrEmpty(nums) && nums.Split(" ").Length == lines)
                {
                    bool check = true;
                    //Console.WriteLine(nums.Split(" ").Length);
                    for (int i = 0; i < lines; i++)
                    {
                        //Console.WriteLine(nums.Split(" ")[i]);
                        if (!byte.TryParse(nums.Split(" ")[i], out byte c))
                        {
                            check = false; break;
                        }
                        numsArr[i] = c;
                    }
                    if (check)
                    {
                        NumbersHistogram(symbol, numsArr);
                        break;
                    }
                }
            }
        }
    }
}
