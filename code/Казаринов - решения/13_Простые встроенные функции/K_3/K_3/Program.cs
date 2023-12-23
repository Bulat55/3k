namespace K_3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Дистанция марафона?");
            int distance = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Сколько пробегает бегун за день?");
            int rangePerDay = Convert.ToInt32(Console.ReadLine());
            marathon(distance, rangePerDay);
            void marathon(double d, double r)
            { 
                Console.WriteLine(Math.Ceiling(d / r));   // округление в большую сторону
            }
        }
    }
}