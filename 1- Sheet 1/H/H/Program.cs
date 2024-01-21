namespace H
{
    internal class Program
    {
        public static void Floor(float a, float b)
        {
            Console.WriteLine($"floor {a} / {b} = {(uint)(a / b)}");
        }
        public static void Ceil(float a, float b)
        {
            float divide = a / b;
            if (divide - (uint)divide == 0.0)
                Console.WriteLine($"ceil {a} / {b} = {(uint)(a / b)}");
            else
                Console.WriteLine($"ceil {a} / {b} = {(uint)(a / b) + 1}");
        }
        public static void Round(float a, float b)
        {
            float divide = a / b;
            float check = divide - (uint)divide;
            if (check >= 0.0 && check < 0.5)
                Console.WriteLine($"round {a} / {b} = {(uint)divide}");
            else
                Console.WriteLine($"round {a} / {b} = {(uint)divide + 1}");
        }

        static void Main(string[] args)
        {
            while (true)
            {
                string? input = Console.ReadLine();
                if(!string.IsNullOrEmpty(input) && input.Split(' ').Length == 2)
                {
                    string[] ab = input.Split(' ');
                    if (float.TryParse(ab[0], out float a) && float.TryParse(ab[1], out float b)
                        && a != 0 && b != 0)
                    {
                        Console.WriteLine($"a / b = {a / b}");
                        Floor(a, b);
                        Ceil(a, b);
                        Round(a, b);
                        break;
                    }
                }
            }
        }
    }
}
