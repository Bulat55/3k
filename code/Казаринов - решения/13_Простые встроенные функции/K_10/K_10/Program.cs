namespace K_10
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string message = Console.ReadLine();
            int messageCost = 40;
            int finalCost = message.Length * messageCost;
            Console.WriteLine(finalCost / 100 + " р. " + finalCost % 100 + " к.");
        }
    }
}