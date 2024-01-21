namespace A
{
    internal class Program
    {
        public static void PriceBeforeDiscount(float x, float p)
        {
            // solved it by equation in my skitsh
            Console.WriteLine($"{p / (1 - (x / 100)):0.00}");
        }

        static void Main(string[] args)
        {
            string? input;
            string[] xp;
            float x;
            float p;
            while (true)
            {
                input = Console.ReadLine();
                if(!string.IsNullOrEmpty(input) && input.Split(" ").Length == 2)
                {
                    xp = input.Split(" ");
                    if (float.TryParse(xp[0], out x) && float.TryParse(xp[1], out p))
                        break;
                }
            }
            PriceBeforeDiscount(x, p);
        }
    }
}
