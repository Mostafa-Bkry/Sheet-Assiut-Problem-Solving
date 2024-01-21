namespace I
{
    internal class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                string? input = Console.ReadLine();
                if (!string.IsNullOrEmpty(input) && input.Split(' ').Length == 2)
                {
                    string[] ab = input.Split(' ');
                    if (ushort.TryParse(ab[0], out ushort a) && ushort.TryParse(ab[1], out ushort b))
                    {        
                        if(a >= b)
                            Console.WriteLine("Yes");
                        else
                            Console.WriteLine("No");
                        break;
                    }
                }
            }
        }
    }
}
