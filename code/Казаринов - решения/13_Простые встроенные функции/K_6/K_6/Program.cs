namespace K_6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            const int ParrotSize = 6;
            Console.WriteLine("Введите строку-удава:");
            string boaString = Console.ReadLine();
            Console.WriteLine(boaString.Length / ParrotSize);
        }
    }
}