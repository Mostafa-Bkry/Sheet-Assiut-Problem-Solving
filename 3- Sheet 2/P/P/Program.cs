namespace P
{
    internal class Program
    {
        public static void Pyramid(byte _n)
        {
            for (int i = _n; i > 0; i--)
            {
                for (int j = 0; j < i; j++)
                {
                    Console.Write('*');
                }
                Console.WriteLine();
            }

            #region Another Way
            //for (int i = 0; i < _n; i++)
            //{
            //    for (int j = 0; j < _n; j++)
            //    {
            //        if (j == _n - i)
            //            break;
            //        Console.Write('*');
            //    }
            //    Console.WriteLine();
            //} 
            #endregion
        }
        
        public static void FullPyramid(byte _n)
        {
            for (int i = 0; i < _n; i++)
            {
                #region Another Hard Ways
                //for(int j = _n; j >= 0; j--)
                //{
                //    if (j == i + 1)
                //    {
                //        for(int  k = 0; k <= i; k++)
                //        {
                //            Console.Write('*');
                //        }
                //        break;
                //    }
                //    Console.Write(' ');
                //} 

                //for(int j = 0; j < _n; j++)
                //{
                //    if (j == _n - i - 1)
                //    {
                //        for(int  k = 0; k <= i; k++)
                //        {
                //            Console.Write('*');
                //        }
                //        break;
                //    }
                //    Console.Write(' ');
                //}
                #endregion

                for (int j = 0; j < _n; j++)
                {
                    if (j >= _n - i - 1)
                    {
                        Console.Write('*');
                        continue;
                    }
                    Console.Write(' ');
                }

                for (int k = 1; k <= i; k++)
                {
                    Console.Write('*');
                }

                Console.WriteLine();
            }
        }

        public static void FullReversedPyramid(byte _n)
        {
            for (int i = 0; i < _n; i++)
            {

                for (int j = 1; j <= _n; j++)
                {
                    if (j <= i)
                    {
                        Console.Write(' ');
                        continue;
                    }
                    Console.Write('*');
                }

                for (int k = i + 1; k < _n; k++)
                {
                    Console.Write('*');
                }
                #region Hard Way of the above loop (int k)
                //for (int k = 0; k < _n; k++)
                //{
                //    if (k == _n - i)
                //    {
                //        for (int l = 0; l <= i; l++)
                //        {
                //            Console.Write(' ');
                //        }
                //        break;
                //    }
                //    Console.Write('*');
                //} 
                #endregion

                Console.WriteLine();
            }
        }

        static void Main(string[] args)
        {
            string? input;
            byte n;
            do
            {
                input = Console.ReadLine();
            } while (string.IsNullOrEmpty(input) || !byte.TryParse(input, out n) || n < 1 || n > 99);

            Pyramid(n);
            //FullPyramid(n);
            //FullReversedPyramid(n);
        }
    }
}
