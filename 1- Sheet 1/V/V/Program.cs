namespace V
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Protective programming
            string? input;
            char[] signs = { '>', '<', '=' };
            string? one = "", two = "";
            sbyte a, b;

            while (true)
            {
                input = Console.ReadLine();
                if (!string.IsNullOrEmpty(input) && (input.Contains(">") || input.Contains("<") || input.Contains("=")))
                {
                    char? c = default;
                    bool reachedTheSign = false;
                    for (int i = 0; i < input.Length; i++)
                    {
                        if (input[i] != '>' && input[i] != '<' && input[i] != '=')
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
                    if (sbyte.TryParse(one, out a) && sbyte.TryParse(two, out b))
                    {
                        switch (c)
                        {
                            case '>':
                                Console.WriteLine(a > b ? "Right" : "Wrong");
                                break;
                            case '<':
                                Console.WriteLine(a < b ? "Right" : "Wrong");
                                break;
                            case '=':
                                Console.WriteLine(a == b ? "Right" : "Wrong");
                                break;
                        }
                        break;
                    }
                }
            }
            #endregion
        }
    }
}
