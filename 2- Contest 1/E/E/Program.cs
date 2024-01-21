namespace E
{
    internal class Program
    {
        public static string CheckIntervals(byte a, byte b)
        {
            if (a == 0 && b == 0)
                return "NO";
            if (a == b)
                return "YES";
            //if (a > b + 1 || b > a + 1)
            //    return "NO";

            byte intervalSize = (byte)(a + b);

            #region Old
            //int[] interval = new int[intervalSize];
            //for(int i = 1, index = 0; i <= 200; i++)
            //{
            //    if (a == 0 && b == 0)
            //        return "NO";
            //    if (a == 100 && b == 100)
            //        return "YES";
            //    if(index > intervalSize)
            //    {
            //        interval[index] = i;
            //        index++;
            //        if(index == intervalSize)
            //        {
            //            int odd = 0, even = 0;
            //            for(int j = 0; j < intervalSize; j++)
            //            {
            //                if (interval[j] % 2 == 0)
            //                    even++;
            //                else
            //                    odd++;
            //            }
            //            if (odd == a &&  even == b)
            //            {
            //                return "YES";
            //            }
            //        }
            //    }
            //    else
            //    {
            //        Array.Clear(interval);
            //        index = 0;
            //    }
            //}
            //return "NO"; 
            #endregion

            //every interval consists from intervalSize elements has a odd and a + 1 even or vice versa
            //the next interval consists from intervalSize elements that are directly after the last the operation is vice versed
            //where  it will be a + 1 odd and a even
            //ex: (1,2,3,4,5) --> 3 odd and 2 even ||||| (6,7,8,9,10) --> 2 odd and 3 even etc.
            //we will loop for (intervalSize * 2) to pass through the two cases

            for (int i = 0, index = 0, odd = 0, even = 0; i < intervalSize * 2; i++)
            {
                if (i % 2 == 0)
                    even++;
                else
                    odd++;
                index++;
                if (index == intervalSize)
                    if (odd == a && even == b)
                        return "YES";
                    else
                        index = odd = even = 0;
            }
            return "NO";
        }

        static void Main(string[] args)
        {
            while (true)
            {
                string? input = Console.ReadLine();
                if(!string.IsNullOrEmpty(input) && input.Split(" ").Length == 2)
                {
                    string[] ab = input.Split(" ");
                    byte a, b;
                    if (byte.TryParse(ab[0], out a) && byte.TryParse(ab[1], out b))
                    {
                        Console.WriteLine(CheckIntervals(a, b));
                        break;
                    }
                }
            }
        }
    }
}
