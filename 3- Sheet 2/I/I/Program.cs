namespace I
{
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
                if (i == s.Length - 1 && s[i] == '0')
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
}
