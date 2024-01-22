using System.ComponentModel.Design;

namespace I
{
    #region Solved with string
    internal class Program
    {
        public static void Palindrome(uint _x)
        {
            string s = _x.ToString();
            string reversedNotLeadingZeros = string.Empty;
            string reversedLeadingZeros = string.Empty;

            for (int i = s.Length - 1; i >= 0; i--)
            {
                reversedLeadingZeros += s[i];
                if (string.IsNullOrEmpty(reversedNotLeadingZeros) && s[i] == '0')
                    continue;
                reversedNotLeadingZeros += s[i];
            }

            Console.WriteLine(reversedNotLeadingZeros);
            //Console.WriteLine(reversedLeadingZeros);
            if (s == reversedLeadingZeros)
                Console.WriteLine("YES");
            else
                Console.WriteLine("NO");
        }

        static void Main(string[] args)
        {
            string? input;
            uint x;
            do
            {
                input = Console.ReadLine();
            }
            while (string.IsNullOrEmpty(input) || !uint.TryParse(input, out x));

            Palindrome(x);
        }
    }
    #endregion


    #region Solved with math
    //public class Program
    //{
    //    static void Main(string[] args)
    //    {
    //        int number = int.Parse(Console.ReadLine());
    //        int remineder, sum = 0;
    //        int temp = number;
    //        string s = string.Empty;
    //        while (number > 0)
    //        {
    //            //Get the remainder by dividing the number with 10  
    //            remineder = number % 10;
    //            if (remineder == 0 && string.IsNullOrEmpty(s)) { }
    //            else s += remineder;
    //            //multiply the sum with 10 and then add the remainder
    //            sum = (sum * 10) + remineder;
    //            //Get the quotient by dividing the number with 10 
    //            number = number / 10;
    //        }
    //        if (temp == sum)
    //        {
    //            Console.WriteLine(s);
    //            Console.WriteLine("YES");
    //        }
    //        else
    //        {
    //            Console.WriteLine(s);
    //            Console.WriteLine("NO");
    //        }
    //        //Console.ReadKey();
    //    }
    //} 
    #endregion
}
