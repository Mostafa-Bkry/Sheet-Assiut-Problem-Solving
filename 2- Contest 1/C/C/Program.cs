namespace C
{
    internal class Program
    {
        public static void NextAlphabet(char c)
        {
            //if (c >= 97 && c <= 121)
            //    c++;
            //else if (c == 122)
            //    c = (char)97;
            if (c == 122)
                Console.WriteLine('a');
            else
                Console.WriteLine(++c);
        }
        static void Main(string[] args)
        {
            char input;

            while (!char.TryParse(Console.ReadLine(), out input) && !char.IsLower(input)) ;

            NextAlphabet(input);
        }
    }
}
