namespace K_7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string nominal = Console.ReadLine();
            int nominalCount = Convert.ToInt32(Console.ReadLine());

            if (nominal == "фартинг")
            {
                Console.WriteLine("Фунтов: { " + nominalCount / 480 + " }");
                Console.WriteLine("Шилингов: { " + nominalCount / 48 + " }");
                Console.WriteLine("Пенсов: { " + nominalCount / 4 + " }");
                Console.WriteLine("Фартингов: { " + nominalCount + " }");
            }

            else if (nominal == "пенс")
            {
                Console.WriteLine("Фунтов: { " + nominalCount / 240 + " }");
                Console.WriteLine("Шилингов: { " + nominalCount / 12 + " }");
                Console.WriteLine("Пенсов: { " + nominalCount + " }");
                Console.WriteLine("Фартингов: { " + nominalCount * 4 + " }");
            }
        }
    }
}