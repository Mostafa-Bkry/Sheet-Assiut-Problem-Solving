namespace Q
{
    internal class Program
    {
        public static void CheckPointQuarter(float x, float y)
        {
            //Q1 + +, Q2 - +, Q3 - -, Q4 + -
            switch ((x, y))
            {
                case ( > 0, > 0):
                    Console.WriteLine("Q1");
                    break;
                case ( < 0, > 0):
                    Console.WriteLine("Q2");
                    break;
                case ( < 0, < 0):
                    Console.WriteLine("Q3");
                    break;
                case ( > 0, < 0):
                    Console.WriteLine("Q4");
                    break;
                case ( 0, 0):
                    Console.WriteLine("Origem");
                    break;
                default:
                    if(y == 0 && (x > 0 || x < 0))
                        Console.WriteLine("Eixo X"); // over x axis
                    else if(x == 0 && (y > 0 || y < 0))
                        Console.WriteLine("Eixo Y"); // over y axis
                    break;
            }
        }

        static void Main(string[] args)
        {
            string? input;
            float x, y;
            do
            {
                input = Console.ReadLine();
            }
            while (string.IsNullOrEmpty(input) || input?.Split(' ').Length != 2
            || !float.TryParse(input.Split(' ')[0], out x) || !float.TryParse(input.Split(' ')[1], out y));

            CheckPointQuarter(x, y);
        }
    }
}
