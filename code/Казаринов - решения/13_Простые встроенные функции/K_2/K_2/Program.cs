namespace K_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите город, в котором Женя побывает в июле:");
            string input1 = Console.ReadLine();
            Console.WriteLine("Введите город, в котором Женя побывает в августе:");
            string input2 = Console.ReadLine();
            routeOfTrip(input1, input2);
            void routeOfTrip(string town1, string town2) 
            {
                if (town1 == town2 || town1 == "Тула" && town2 == "Пенза") { Console.WriteLine("НЕТ"); }
                else { Console.WriteLine("ДА"); }
            }
        }
    }
}