namespace K_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string input1 = Convert.ToString(Console.ReadLine());
            string input2 = Convert.ToString(Console.ReadLine());

            if (input1 == "да" && input2 == "да" || input1 == "нет" && input2 == "нет") Console.WriteLine("Верно");
            else Console.WriteLine("Неверно");
        }
    }
}