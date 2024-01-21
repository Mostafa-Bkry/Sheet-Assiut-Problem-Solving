namespace C
{
    internal class Program
    {
        public static void Calculator(ulong x, ulong y)
        {
            Console.WriteLine($"{x} + {y} = {x + y}");
            Console.WriteLine($"{x} * {y} = {x * y}");
            Console.WriteLine($"{x} - {y} = {x - y}");
        }

        static void Main(string[] args)
        {
            string? nums;
            
            while (true)
            {
                nums = Console.ReadLine();
                if (!string.IsNullOrWhiteSpace(nums) && nums.Split(' ').Length == 2)
                    break;
            }
            string[] xy = nums.Split(' ');
            if (ulong.TryParse(xy[0], out ulong x) && ulong.TryParse(xy[1], out ulong y))
                Calculator(x, y);
        }
    }
}
