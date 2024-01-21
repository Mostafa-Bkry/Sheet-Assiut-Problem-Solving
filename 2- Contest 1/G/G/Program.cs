using System.ComponentModel.Design;

namespace G
{
    internal class Program
    {
        public static decimal KatryoshkasNum(decimal e, decimal m, decimal b)
        {
            /*
                1. Two eyes and one body.
                2. Two eyes, one mouth, and one body.
                3. One eye, one mouth, and one body.
             */

            decimal type1 = 0, type2 = 0, type3 = 0;
            decimal remainE, remainB;

            if (e == 0)
                return 0;
            else if (e < m && e < b)
                return (decimal)e;
            else if (e > m && e > b)
            {
                if (m >= b)
                    type3 = b;
                else
                {
                    type3 = m;
                    remainE = e - m;
                    remainB = b - m;
                    if (remainE / 2 >= remainB)
                        type1 = remainB;
                    else
                        type1 = (ulong)(remainE / 2);
                }

                return (decimal)(type1 + type2 + type3);
            }
            else if (e > m && e < b)
            {
                type3 = m;
                remainE = e - m;
                type1 = (ulong)(remainE / 2);

                return (decimal)(type1 + type2 + type3);
            }
            else if (e < m && e > b)
            {
                type3 = b;

                return (decimal)(type1 + type2 + type3);
            }
            else if (e == m && e == b)
            {
                type3 = e;

                return (decimal)(type1 + type2 + type3);
            }
            else if (e == m && e > b)
            {
                type3 = b;

                return (decimal)(type1 + type2 + type3);
            }
            else if (e == m && e < b)
            {
                type3 = e;

                return (decimal)(type1 + type2 + type3);
            }
            else if (e == b && e < m)
            {
                type3 = e;

                return (decimal)(type1 + type2 + type3);
            }
            else if (e == b && e > m)
            {
                type3 = m;
                remainE = e - m;
                type1 = (ulong)(remainE / 2);

                return (decimal)(type1 + type2 + type3);
            }
            
            return 0;
            
            //if (e % 2 == 0)
            //{
            //    if (e / 2 >= b)
            //        type1 = b;
            //    else if (e / 2 < b)
            //        type1 = e;
            //}
            //else
            //{
            //    remainE = (e / 2) - (ulong)(e / 2);
            //    if ((ulong)(e / 2) >= b)
            //        type1 = b;
            //}

        }
        static void Main(string[] args)
        {
            while (true)
            {
                string? input = Console.ReadLine();
                if (!string.IsNullOrEmpty(input) && input.Split(" ").Length == 3)
                {
                    string[] ab = input.Split(" ");
                    if (decimal.TryParse(ab[0], out decimal a) && decimal.TryParse(ab[1], out decimal b)
                        && decimal.TryParse(ab[2], out decimal c))
                    {
                        Console.WriteLine(KatryoshkasNum(a, b, c));
                        break;
                    }
                }
            }
        }
    }
}
