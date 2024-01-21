namespace O
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Protective programming
            //string? input;
            ////string[] signs = { "+", "-", "*", "/" };
            //char[] signs = { '+', '-', '*', '/' };
            //string? one = "", two = "";
            //ushort a, b;

            //while (true)
            //{
            //    input = Console.ReadLine();
            //    if (!string.IsNullOrEmpty(input) 
            //        && (input.Contains("+") || input.Contains("-") || input.Contains("*") || input.Contains("/")))
            //    {
            //        char? c = default;
            //        bool reachedTheSign = false;
            //        for (int i = 0; i < input.Length; i++)
            //        {
            //            if (input[i] != '+' && input[i] != '-' && input[i] != '*' && input[i] != '/')
            //            {
            //                if (!reachedTheSign)
            //                    one += input[i];
            //                else
            //                    two += input[i];
            //            }
            //            else
            //            {
            //                reachedTheSign = true;
            //                c = input[i];
            //            }
            //        }
            //        if (ushort.TryParse(one, out a) && ushort.TryParse(two, out b))
            //        {
            //            switch (c)
            //            {
            //                case '+':
            //                    Console.WriteLine(a + b);
            //                    break;
            //                case '-':
            //                    Console.WriteLine(a - b);
            //                    break;
            //                case '*':
            //                    Console.WriteLine(a * b);
            //                    break;
            //                case '/':
            //                    Console.WriteLine(a / b);
            //                    break;
            //            }
            //            break;
            //        }
            //    }
            //} 
            #endregion

            string? input = Console.ReadLine();
            string? one = "", two = "";
            ushort a, b;

            char? c = default;
            bool reachedTheSign = false;
            for (int i = 0; i < input?.Length; i++)
            {
                if (input[i] != '+' && input[i] != '-' && input[i] != '*' && input[i] != '/')
                {
                    if (!reachedTheSign)
                        one += input[i];
                    else
                        two += input[i];
                }
                else
                {
                    reachedTheSign = true;
                    c = input[i];
                }
            }
            if (ushort.TryParse(one, out a) && ushort.TryParse(two, out b))
            {
                switch (c)
                {
                    case '+':
                        Console.WriteLine(a + b);
                        break;
                    case '-':
                        Console.WriteLine(a - b);
                        break;
                    case '*':
                        Console.WriteLine(a * b);
                        break;
                    case '/':
                        Console.WriteLine(a / b);
                        break;
                }
            }
        }
    }
}
