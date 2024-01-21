namespace T
{
    internal class Program
    {
        public static void SortNums(int a, int b, int c)
        {
            int[] nums = new int[3];
            if (a >= b && a >= c)
            {
                if (b >= c)
                {
                    nums[0] = a;
                    nums[1] = b;
                    nums[2] = c;
                }
                else
                {
                    nums[0] = a;
                    nums[1] = c;
                    nums[2] = b;
                }
            }
            else if (b >= a && b >= c)
            {
                if (a >= c)
                {
                    nums[0] = b;
                    nums[1] = a;
                    nums[2] = c;
                }
                else
                {
                    nums[0] = b;
                    nums[1] = c;
                    nums[2] = a;
                }
            }
            else
            {
                if (a >= b)
                {
                    nums[0] = c;
                    nums[1] = a;
                    nums[2] = b;
                }
                else
                {
                    nums[0] = c;
                    nums[1] = b;
                    nums[2] = a;
                }
            }

            for(int i = nums.Length - 1; i >= 0; i--)
                Console.WriteLine(nums[i]);
            Console.WriteLine();
            Console.WriteLine(a);
            Console.WriteLine(b);
            Console.WriteLine(c);
        }

        static void Main(string[] args)
        {
            while (true)
            {
                string? input = Console.ReadLine();
                if (!string.IsNullOrEmpty(input) && input.Split(' ').Length == 3)
                {
                    string[] ab = input.Split(' ');
                    if (int.TryParse(ab[0], out int a) && int.TryParse(ab[1], out int b) && int.TryParse(ab[2], out int c))
                    {
                        SortNums(a, b, c);
                        break;
                    }
                }
            }
        }
    }
}
