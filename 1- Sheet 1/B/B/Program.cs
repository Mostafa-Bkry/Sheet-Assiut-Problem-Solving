namespace B
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string s = Console.ReadLine();
            string[] ss = s.Split(' ');
            for(int i = 0; i < ss.Length; i++)
                Console.WriteLine(ss[i]);
        }
    }
}
