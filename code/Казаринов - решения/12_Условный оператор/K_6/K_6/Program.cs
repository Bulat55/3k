namespace K_6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите логин: ");
            string login = Convert.ToString(Console.ReadLine());
            Console.WriteLine("Введите резервную эл. почту: ");
            string reserveEmail = Convert.ToString(Console.ReadLine());

            if (login.Contains('@'))
            {
                Console.WriteLine("Нерректный логин");
            }
            else
            {
                if (!(reserveEmail.Contains('@')))
                {
                    Console.WriteLine("Некорректная резервная эл. почта");
                }

                else Console.WriteLine("OK");
            }
        }
    }
}