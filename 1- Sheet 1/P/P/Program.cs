namespace P
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ushort value;
            while(!ushort.TryParse(Console.ReadLine(), out value) || value <= 999);

            char first = value.ToString()[0];
            byte firstNumber = byte.Parse(first.ToString());
            if(firstNumber % 2 == 0)
                Console.WriteLine("EVEN");
            else
                Console.WriteLine("ODD");
        }
    }
}
