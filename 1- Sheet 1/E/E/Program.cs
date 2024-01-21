namespace E
{
    internal class Program
    {
        public static void CircleArea(double R)
        {
            const double pi = 3.141592653;
            Console.WriteLine($"{pi * R * R :0.000000000}");
        }
        static void Main(string[] args)
        {
            double R;
            while (!double.TryParse(Console.ReadLine(), out R)) ;
            CircleArea(R);
            //Console.WriteLine(string.Format("{0:0.0000}", R));
            //Console.WriteLine($"{R:0.00}");

        }
    }
}
