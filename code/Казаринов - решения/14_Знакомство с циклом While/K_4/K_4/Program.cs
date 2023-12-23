namespace K_4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string input;
            while (true) 
            {
                    input = Console.ReadLine();
                    int counter = 0;
                    int height = Convert.ToInt32(input);
                    int max = 0;
                    int min = 0;
                    if (height < 190 && height > 150)
                    {
                        counter++;
                    }

                    if (height > max) max = height;

                    if (height < min) min = height;
                

                    if (input == "-1")
                    {
                        Console.WriteLine(counter);
                        Console.WriteLine(max + "" + min);
                        break;
                    }
                
            }
        }
    }
}