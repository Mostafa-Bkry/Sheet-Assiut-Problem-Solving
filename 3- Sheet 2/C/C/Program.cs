using System.Windows.Markup;

namespace C
{
    internal class Program
    {
        public static string EvenOddPosNeg(int[] _valuesArr)
        {
            int even = 0, odd = 0, positive = 0, negative = 0;

            for (int i = 0; i < _valuesArr.Length; i++) 
            {
                if (_valuesArr[i] % 2 == 0)
                    even++;
                else
                    odd++;
                if (_valuesArr[i] > 0)
                    positive++;
                else if (_valuesArr[i] < 0)
                    negative++;
            }
            return $"Even: {even}\nOdd: {odd}\nPositive: {positive}\nNegative: {negative}";
        }

        static void Main(string[] args)
        {
            string? numOfValues, values;
            short n;

            do
            {
                numOfValues = Console.ReadLine();
            }
            while (string.IsNullOrEmpty(numOfValues) || !short.TryParse(numOfValues, out n) || n < 1 || n > 1000);

            // check if any value is invalid and can't be casted to int then use the above method
            while (true)
            {
                values = Console.ReadLine();
                if(!string.IsNullOrEmpty(values) && values.Split(" ").Length == n)
                {
                    string[] input = values.Split(" ");
                    bool notValidInput = false;
                    int[] valuesArr = new int[input.Length];

                    for (int i = 0; i < input.Length; i++)
                    {
                        if (!int.TryParse(input[i], out valuesArr[i]))
                        {
                            notValidInput = true;
                            break;
                        }
                    }
                    if (notValidInput)
                        continue;
                    Console.WriteLine(EvenOddPosNeg(valuesArr));
                    break;
                }

            }
        }
    }
}
