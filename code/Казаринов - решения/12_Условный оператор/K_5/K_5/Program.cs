namespace K_5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string input1 = Convert.ToString(Console.ReadLine());
            string input2 = Convert.ToString(Console.ReadLine());
            string input3 = Convert.ToString(Console.ReadLine());

            if (((input1 == "раз" || input1 == "один") && input2 == "два" && input3 == "три") || (input1 == "1" && input2 == "2" && input3 == "3"))
                Console.WriteLine("ГОРИ");
            else Console.WriteLine("НЕ ГОРИ");
        }
    }
}