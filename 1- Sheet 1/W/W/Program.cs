namespace W
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Protective programming
            string? input;
            char[] signs = { '+', '-', '*', '=' };
            string? one = "", two = "", three = "";
            sbyte a, b;
            int result;

            while (true)
            {
                input = Console.ReadLine();
                if (!string.IsNullOrEmpty(input)
                    && (input.Contains("+") || input.Contains("-") || input.Contains("*") && input.Contains("=")))
                {
                    char? c = default;
                    bool reachedTheSign = false;
                    for (int i = 0; i < input.Length; i++)
                    {
                        if (input[i] == ' ')
                            continue;
                        else
                        {
                            if (input[i] == '=')
                            {
                                for (int j = i + 1; j < input.Length; j++)
                                    three += input[j];
                                break;
                            }
                            else
                            {
                                if (input[i] != '+' && input[i] != '-' && input[i] != '*' && input[i] != '=')
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
                        }
                    }
                    if (sbyte.TryParse(one, out a) && sbyte.TryParse(two, out b) && int.TryParse(three, out result))
                    {
                        switch (c)
                        {
                            case '+':
                                Console.WriteLine(a + b == result ? "Yes" : a + b);
                                break;
                            case '-':
                                Console.WriteLine(a - b == result ? "Yes" : a - b);
                                break;
                            case '*':
                                Console.WriteLine(a * b == result ? "Yes" : a * b);
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
