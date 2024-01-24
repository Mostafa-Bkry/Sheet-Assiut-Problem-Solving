namespace V
{
    internal class Program
    {
        public static void PUM(byte n)
        {
            byte sequance = 1;

            for (int i = 0; i < n; i++)
            {
                byte line = 4;
                byte pum = 1;
                while(line > 0)
                {
                    if(pum == 4)
                    {
                        Console.Write("PUM");
                        sequance++;
                    }
                    else
                    {
                        Console.Write($"{sequance} ");
                        sequance++;
                    }
                    pum++;
                    line--;
                }
                Console.WriteLine();
            }
        }

        static void Main(string[] args)
        {
            string? input;
            byte n;

            do
            {
                input = Console.ReadLine();
            }
            while (string.IsNullOrEmpty(input) || !byte.TryParse(input, out n) || n < 1 || n > 20);

            PUM(n);
        }
    }
}
