namespace A
{
    internal class Program
    {
        public static void Hello(string name)
        {
            Console.WriteLine($"Hello, {name}");
        }

        static void Main(string[] args)
        {
            Hello(Console.ReadLine());
        }
    }
}
