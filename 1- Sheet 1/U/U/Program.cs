namespace U
{
    internal class Program
    {
        public static void CheckFloatOrInt(float n)
        {
            ushort check = (ushort)n;
            if(n - check == 0)
                Console.WriteLine($"int {check}");
            else
                Console.WriteLine($"float {check} {n - check :0.000}");
        }

        static void Main(string[] args)
        {
            float result;
            while (!float.TryParse(Console.ReadLine(), out result)) ;

            CheckFloatOrInt(result);
        }
    }
}
