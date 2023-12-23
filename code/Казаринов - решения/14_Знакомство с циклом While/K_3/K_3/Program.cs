namespace K_3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int wealth = Convert.ToInt32(Console.ReadLine());
            while (true) 
            {
                wealth /= 8;
                wealth /= 8;
                if (wealth / 8 == 0) 
                {
                    Console.WriteLine(wealth);
                    break;
                }
            }
        }
    }
}