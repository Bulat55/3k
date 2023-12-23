namespace K_5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int input = Convert.ToInt32(Console.ReadLine());
            int calc = (((((((input + (input + 1))*(input + 2) + (input + 3)) * (input + 4)) + (input + 5)) * (input + 6)) + (input + 7)) * (input + 8));
            Console.WriteLine(calc);
        }
    }
}