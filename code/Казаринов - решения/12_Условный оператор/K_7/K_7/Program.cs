namespace K_7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine();
            if (int.TryParse(input, out var time))
            {
                if (time > 5 && time < 10) { Console.WriteLine("Утро"); }
                    else if (time > 11 && time < 17) { Console.WriteLine("День"); }
                        else if (time > 18 && time < 22) { Console.WriteLine("Вечер"); }
                            else if (time == 23 || time == 0 && time < 4) { Console.WriteLine("Ночь"); }
                                else Console.WriteLine("Ошибка");
            }
            else
            {
                Console.WriteLine("Ошибка");
            }
        }
    }
}