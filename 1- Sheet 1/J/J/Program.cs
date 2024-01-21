namespace J
{
    internal class Program
    {
        public static void MultipleOrNot(float a, float b)
        {
            if (a >= b && ((a / b) - (uint)(a / b)) == 0)
                Console.WriteLine("Multiples");
            else if (b >= a && ((b / a) - (uint)(b / a)) == 0)
                Console.WriteLine("Multiples");
            else
                Console.WriteLine("No Multiples");
        }
        static void Main(string[] args)
        {
            //while (true)
            //{
            //    string? input = Console.ReadLine();
            //    if (!string.IsNullOrEmpty(input) && input.Split(' ').Length == 2)
            //    {
            //        string[] ab = input.Split(' ');
            //        if (float.TryParse(ab[0], out float a) && float.TryParse(ab[1], out float b)
            //            && a != 0 && b != 0)
            //        {
            //            MultipleOrNot(a, b);
            //            break;
            //        }
            //    }
            //}
            string s = Console.ReadLine();
            string[] ab = s.Split(' ');
            MultipleOrNot(float.Parse(ab[0]), float.Parse(ab[1]));
        }
    }
}
