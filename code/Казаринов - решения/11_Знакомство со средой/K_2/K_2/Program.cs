namespace K_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("1 бит - минимальная единица количества информации.");
            Console.WriteLine("1 байт = 8 бит.");
            Console.WriteLine("1 Килобит = 1024 бита.");
            Console.WriteLine("1 Килобайт = 1024 байта.");
            int byteAsBit = 8;
            int kilobyteAsBit = 1024 * byteAsBit;
            Console.WriteLine("1 килобайт = " +  kilobyteAsBit + " бит.");
        }
    }
}