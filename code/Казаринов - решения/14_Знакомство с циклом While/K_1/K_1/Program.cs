namespace K_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double price = 0;
            while (true) 
            {
                double input = Convert.ToDouble(Console.ReadLine());
                price += input - input * 0.05;
                if (input == -1)
                {
                    Console.WriteLine(price);
                    break;
                }
            }
        }
    }
}