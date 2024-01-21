namespace E
{
    internal class Program
    {
        public static int Max(int[] _valuesArr)
        {
            int maxOne = 0;
            for(int i = 0; i < _valuesArr.Length; i++)
            {
                if (_valuesArr[i] > maxOne)
                    maxOne = _valuesArr[i];
            }
            return maxOne;
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
                if (!string.IsNullOrEmpty(values) && values.Split(" ").Length == n)
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
                    Console.WriteLine(Max(valuesArr));
                    break;
                }

            }
        }
    }
}
