namespace K_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                string password1 = Console.ReadLine();
                string password2 = Console.ReadLine();
                if (password1.Length < 8) 
                {
                    Console.WriteLine("Короткий!");
                    break;
                }
                    else if (password1 != password2) 
                    { 
                        Console.WriteLine("Не совпадают!"); 
                        break; 
                    }
                        else 
                        { 
                            Console.WriteLine("OK"); 
                            break; 
                        }
            }
        }
    }
}