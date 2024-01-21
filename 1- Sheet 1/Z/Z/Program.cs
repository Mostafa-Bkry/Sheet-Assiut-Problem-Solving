namespace Z
{
    internal class Program
    {
        public static void CheckPowers(uint a, ulong b, uint c, ulong d)
        {
            double ab = b * Math.Log(a);
            double cd = d * Math.Log(c);
                if (ab > cd)
                    Console.WriteLine("YES");
                else
                    Console.WriteLine("NO");
        }
        static void Main(string[] args)
        {
            while (true)
            {
                string? input = Console.ReadLine();
                if (!string.IsNullOrEmpty(input) && input.Split(' ').Length == 4)
                {
                    string[] ab = input.Split(' ');
                    if (uint.TryParse(ab[0], out uint a) && ulong.TryParse(ab[1], out ulong b)
                        && uint.TryParse(ab[2], out uint c) && ulong.TryParse(ab[3], out ulong d))
                    {
                        CheckPowers(a, b, c, d);
                        break;
                    }
                }
            }
        }
    }
}
