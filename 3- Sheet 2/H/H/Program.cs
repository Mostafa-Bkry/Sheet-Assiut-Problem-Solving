namespace H
{
    internal class Program
    {
        public static bool Prime(float x)
        {
            for(int i = 2; i < x; i++)
            {
                //Console.WriteLine(x / i);
                if ((x / i) - (int)(x / i) == 0)
                    return false;
            }
            return true;
        }

        static void Main(string[] args)
        {
            string? input;
            float x;
            do
            {
                input = Console.ReadLine();
            }
            while (string.IsNullOrEmpty(input) || !float.TryParse(input, out x));

            Console.WriteLine(Prime(x) ? "YES" : "NO");
        }
    }
}
