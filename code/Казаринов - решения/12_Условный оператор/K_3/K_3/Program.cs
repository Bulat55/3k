namespace K_3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string input1 = Convert.ToString(Console.ReadLine());
            string input2 = Convert.ToString(Console.ReadLine());
            string input3 = Convert.ToString(Console.ReadLine());

            if (input1 == "раз" && input2 == "два" && input3 == "три") Console.WriteLine("ГОРИ");
            else Console.WriteLine("НЕ ГОРИ");
        }
    }
}