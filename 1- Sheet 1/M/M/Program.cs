namespace M
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region ASCII NOTES
            /*
             Note:
                Digits in ASCII '0' = 48,'1' = 49 ....etc
                Capital letters in ASCII 'A' = 65, 'B' = 66 ....etc
                Small letters in ASCII 'a' = 97,'b' = 98 ....etc
             */
            #endregion

            #region using .net methods
            //string? input = Console.ReadLine();
            //if(char.IsAsciiLetterUpper(Convert.ToChar(input)))
            //    Console.WriteLine("ALPHA\nIS CAPITAL");
            //else if(char.IsAsciiLetterLower(Convert.ToChar(input)))
            //    Console.WriteLine("ALPHA\nIS SMALL");
            //else if(char.IsAsciiDigit(Convert.ToChar(input)))
            //    Console.WriteLine("IS DIGIT"); 
            #endregion

            string? input;
            char result;
            do
            {
                input = Console.ReadLine();
            }
            while (string.IsNullOrEmpty(input) || input.Length > 1 || input[0] == ' ' || !char.TryParse(input, out result));

            if (result >= 48 && result <= 57)
                Console.WriteLine("IS DIGIT");
            else if (result >= 65 && result <= 90)
                Console.WriteLine("ALPHA\nIS CAPITAL");
            else if (result >= 97 && result <= 122)
                Console.WriteLine("ALPHA\nIS SMALL");

        }
    }
}
