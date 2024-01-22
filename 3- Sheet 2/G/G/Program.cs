#region Protective Programming
namespace G
{
    internal class Program
    {
        public static decimal Factorial(byte n)
        {
            decimal result = 1;

            for (int i = 1; i <= n; i++)
                result *= i;

            return result;
        }

        static void Main(string[] args)
        {
            string? numOfTestCases, caseN;
            byte t;

            do
            {
                numOfTestCases = Console.ReadLine();
            }
            while (string.IsNullOrEmpty(numOfTestCases) || !byte.TryParse(numOfTestCases, out t) || t < 1 || t > 15);

            byte n;

            for(int i = 0; i < t; i++)
            {
                do
                {
                    caseN = Console.ReadLine();
                }
                while (string.IsNullOrEmpty(caseN) || !byte.TryParse(caseN, out n) || n < 0 || n > 20);

                if (n == 0)
                    Console.WriteLine(1);
                else
                    Console.WriteLine(Factorial(n));
            }
        }
    }
}
#endregion

#region Another Way
//static void Main(string[] args)
//{
//    string? numOfTestCases, caseN;
//    byte t;

//    do
//    {
//        numOfTestCases = Console.ReadLine();
//    }
//    while (string.IsNullOrEmpty(numOfTestCases) || !byte.TryParse(numOfTestCases, out t) || t < 1 || t > 15);

//    uint[] resultsArr = new uint[t];
//    byte n;

//    for (int i = 0; i < t; i++)
//    {
//        do
//        {
//            caseN = Console.ReadLine();
//        }
//        while (string.IsNullOrEmpty(caseN) || !byte.TryParse(caseN, out n) || n < 0 || n > 20);

//        if (n == 0)
//            Console.WriteLine(1);
//        else
//        {
//            resultsArr[i] = Factorial(n);
//        }
//    }

//    foreach (uint num in resultsArr)
//        Console.WriteLine(num);
//} 
#endregion

#region Not Protective
//namespace G
//{
//    internal class Program
//    {
//        public static int Factorial(int n)
//        {
//            int result = 1;

//            for (int i = 2; i <= n; i++)
//                result *= i;

//            return result;
//        }

//        static void Main(string[] args)
//        {
//            int t = int.Parse(Console.ReadLine());

//            int n;

//            while(t > 0)
//            {
//                n = int.Parse(Console.ReadLine());

//                if (n == 0)
//                    Console.WriteLine(1);
//                else
//                    Console.WriteLine(Factorial(n));
//                t--;
//            }
//        }
//    }
//} 
#endregion

