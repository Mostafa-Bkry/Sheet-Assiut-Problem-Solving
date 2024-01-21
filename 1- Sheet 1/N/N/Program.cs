namespace N
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Note : difference between 'a' and 'A' in ASCII is 32 .
            string? input;
            char result;
            //do
            //{
            //    input = Console.ReadLine();
            //}
            //while (string.IsNullOrEmpty(input) || input.Length  != 1 || input[0] == ' ' || !char.TryParse(input, out result)
            //|| !(result >= 65 && result <= 90) || !(result >= 97 && result <= 122));

            while (true)
            {
                input = Console.ReadLine();
                if (!string.IsNullOrEmpty(input) && input.Length == 1 && input[0] != ' ' && char.TryParse(input, out result))
                {
                    if ((result >= 65 && result <= 90) || (result >= 97 && result <= 122))
                        break;
                }
            }

            if (result >= 65 && result <= 90)
                Console.WriteLine((char)(result + 32));
            else if (result >= 97 && result <= 122)
                Console.WriteLine((char)(result - 32));
        }
    }
}
