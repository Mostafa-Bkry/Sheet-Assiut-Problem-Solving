namespace D
{
    internal class Program
    {
        public static void EquaCalc(long a, long b, long c , long d)
        {
            Console.WriteLine($"Difference = {(a * b) - (c * d)}");
        }
        static void Main(string[] args)
        {
            string? nums;
            while (true)
            {
                nums = Console.ReadLine();
                if (!string.IsNullOrWhiteSpace(nums) && nums.Split(' ').Length == 4)
                {
                    string[] s = nums.Split(' ');
                    if (long.TryParse(s[0], out long a) && long.TryParse(s[1], out long b) 
                        && long.TryParse(s[2], out long c) && long.TryParse(s[3], out long d))
                    {
                        EquaCalc(a, b, c, d);
                        break;
                    }
                }
            }
        }
    }
}
