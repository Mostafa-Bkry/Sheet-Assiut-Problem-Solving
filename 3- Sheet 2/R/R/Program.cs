namespace R
{
    internal class Program
    {
        public static void SequenceOfNumsAndSum(sbyte n, sbyte m)
        {
            sbyte biggest = n >= m ? n : m;
            sbyte smallest = n >= m ? m : n;
            double sum = 0;

            //for (int i = n >= m ? m : n; i < (n >= m ? n : m); i++)
            for(int i = smallest; i <= biggest; i++)
            {
                sum += i;
                Console.Write($"{i} ");
            }
            Console.Write($"sum ={sum}");
            Console.WriteLine();
        }

        static void Main(string[] args)
        {
            string? input;
            sbyte n, m;

            while (true)
            {

                input = Console.ReadLine();

                if (!string.IsNullOrEmpty(input) && input.Split(" ").Length == 2 && sbyte.TryParse(input.Split(" ")[0], out n)
                    && sbyte.TryParse(input.Split(" ")[1], out m))
                {
                    if (n > 0 && m > 0)
                        SequenceOfNumsAndSum(n, m);
                    else
                        break;
                }
            }
        }
    }
}
