using System.ComponentModel;

namespace F
{
    internal class Program
    {
        public static void AddingTwoBinaries(uint a, uint b)
        {
            string binaryA = Convert.ToString(a, 2);
            //Console.WriteLine($"before reversing binaryA = {binaryA}");
            string binaryB = Convert.ToString(b, 2);
            //Console.WriteLine($"before reversing binaryB = {binaryB}");

            char[] charArrA = binaryA.ToCharArray();
            char[] charArrB = binaryB.ToCharArray();
            Array.Reverse(charArrA);
            Array.Reverse(charArrB);
            binaryA = new string(charArrA);
            binaryB = new string(charArrB);
            //Console.WriteLine($"After reversing binaryA = {binaryA}");
            //Console.WriteLine($"After reversing binaryB = {binaryB}");

            byte biggerLength;

            if (binaryA.Length > binaryB.Length)
                biggerLength = (byte)binaryA.Length;
            else
                biggerLength = (byte)binaryB.Length;


            string result = "";
            for (int i = 0; i < biggerLength; i++)
            {
                if (i > binaryA.Length - 1)
                {
                    //Console.WriteLine($"binaryB[{i}] = {binaryB[i]}");
                    result += binaryB[i];
                    continue;
                }
                else if(i > binaryB.Length - 1)
                {
                    //Console.WriteLine($"binaryA[{i}] = {binaryA[i]}");
                    result += binaryA[i];
                    continue;
                }
                //Console.WriteLine($"binaryA[{i}] = {binaryA[i]}");
                //Console.WriteLine($"binaryB[{i}] = {binaryB[i]}");
                if (binaryA[i] == binaryB[i])
                    result += "0";
                else
                    result += "1";
            }
            char[] charArrResult = result.ToCharArray();
            Array.Reverse(charArrResult);
            result = new string(charArrResult);
            //Console.WriteLine(result);
            Console.WriteLine(Convert.ToInt32(result, 2));
        }

        static void Main(string[] args)
        {
            while (true)
            {
                string? input = Console.ReadLine();
                if(!string.IsNullOrEmpty(input) && input.Split(" ").Length == 2) 
                {
                    string[] ab = input.Split(" ");
                    if (uint.TryParse(ab[0], out uint a) && uint.TryParse(ab[1], out uint b))
                    {
                        AddingTwoBinaries(a, b);
                        break;
                    }
                }
            }
        }
    }
}
