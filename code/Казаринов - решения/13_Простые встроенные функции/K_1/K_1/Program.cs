namespace K_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            int countOfLetters = input.Length;
            Console.WriteLine("Слово {0} имеет длину {1}", input, countOfLetters);
        }
    }
}