namespace X
{
    internal class Program
    {
        public static string CheckIntervalsIntersection(uint l1, uint r1, uint l2, uint r2)
        {
            uint from, to;
            //if(l2 < l1 && r2 < l1)
            //    Console.WriteLine(-1);
            if (l2 < r1)
            {
                if (l2 >= l1)
                    from = l2;
                else
                {
                    if (r2 < l1)
                        return "-1";
                    else
                        from = l1;
                }
                if (r2 >= r1)
                    to = r1;
                else
                    to = r2;
                return $"{from} {to}";
            }
            else if (l2 == r1)
            {
                from = to = r1;
                return $"{from} {to}";
            }
            else
                return "-1" ;
        }

        static void Main(string[] args)
        {
            while (true)
            {
                string? input = Console.ReadLine();
                if (!string.IsNullOrEmpty(input) && input.Split(' ').Length == 4)
                {
                    string[] ab = input.Split(' ');
                    if (uint.TryParse(ab[0], out uint a) && uint.TryParse(ab[1], out uint b)
                        && uint.TryParse(ab[2], out uint c) && uint.TryParse(ab[3], out uint d))
                    {
                        Console.WriteLine(CheckIntervalsIntersection(a, b, c, d));
                        break;
                    }
                }
            }
        }
    }
}
