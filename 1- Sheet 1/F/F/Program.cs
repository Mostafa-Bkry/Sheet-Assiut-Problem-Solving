namespace F
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string? nums;
            while (true)
            {
                nums = Console.ReadLine();
                if (!string.IsNullOrEmpty(nums) && nums.Split(' ').Length == 2)
                {
                    string[] nm = nums.Split(" ");
                    if (ulong.TryParse(nm[0], out ulong N) && ulong.TryParse(nm[1], out ulong M))
                    {
                        Console.WriteLine($"{(N % 10) + (M % 10)}");
                        break;
                    }
                }
            }
            //Console.WriteLine(1 % 10);
        }
    }
}
