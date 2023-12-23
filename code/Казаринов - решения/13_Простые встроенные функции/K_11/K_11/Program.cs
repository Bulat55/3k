namespace K_11
{
    internal class Program
    {
        static void Main(string[] args)
        {
            float number = Convert.ToSingle(Console.ReadLine());
            if (Math.Sign(number) == 0) { Console.WriteLine("0"); }
                else if (Math.Sign(number) == 1) { Console.WriteLine("+"); }
                    else if (Math.Sign(number) == -1) { Console.WriteLine("-"); }
            
        }
    }
}