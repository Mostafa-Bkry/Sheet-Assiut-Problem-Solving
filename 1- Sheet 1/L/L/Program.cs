namespace L
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string? firstPerson, secondPerson;
            do
            {
                //Console.WriteLine(1);
                firstPerson = Console.ReadLine();
            }
            while (string.IsNullOrEmpty(firstPerson) || firstPerson?.Split(' ').Length != 2
            || string.IsNullOrEmpty(firstPerson?.Split(' ')[0]) || string.IsNullOrEmpty(firstPerson?.Split(' ')[1]));
            do
            {
                //Console.WriteLine(2);
                secondPerson = Console.ReadLine();
            }
            while (string.IsNullOrEmpty(secondPerson) || secondPerson?.Split(' ').Length != 2
            || string.IsNullOrEmpty(secondPerson?.Split(' ')[0]) || string.IsNullOrEmpty(secondPerson?.Split(' ')[1]));

            string[] Person1 = firstPerson.Split(' ');
            string[] Person2 = secondPerson.Split(' ');
            if (Person1[1] == Person2[1])
                Console.WriteLine("ARE Brothers");
            else
                Console.WriteLine("NOT");
        }
    }
}
