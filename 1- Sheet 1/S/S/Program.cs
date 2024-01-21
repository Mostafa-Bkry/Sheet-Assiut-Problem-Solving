namespace S
{
    internal class Program
    {
        public static void CheckIntervals(float x)
        {
            /*
             * [0,25], (25,50], (50,75], (75,100]
                The symbol '(' represents greater than.
                The symbol ')' represents smaller than.
                The symbol '[' represents greater than or equal.
                The symbol ']' represents smaller than or equal
             */

            if(x >= 0 && x <= 25)
                Console.WriteLine("Interval [0,25]");
            else if(x > 25 && x <= 50)
                Console.WriteLine("Interval (25,50]");
            else if(x > 50 && x <= 75)
                Console.WriteLine("Interval (50,75]");
            else if (x > 75 && x <= 100)
                Console.WriteLine("Interval (75,100]");
            else
                Console.WriteLine("Out of Intervals");

        }
        static void Main(string[] args)
        {
            float result;
            while(!float.TryParse(Console.ReadLine(), out result)) ;
            CheckIntervals(result);
        }
    }
}
