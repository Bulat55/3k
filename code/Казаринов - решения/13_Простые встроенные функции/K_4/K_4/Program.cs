namespace K_4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите длину бассейна:");
            int length = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите ширину бассейна:");
            int width = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите высоту бассейна:");
            int height = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите скорость наполнения бассейна:");
            double waterFlowPerHour = Convert.ToDouble(Console.ReadLine());
            FillPool(length, width, height, waterFlowPerHour);
            void FillPool(int length, int width, int height, double waterFlowPerHour) 
            {
                int poolVolume = length * width * height;
                Console.WriteLine(poolVolume /  waterFlowPerHour);
            }

        }
    }
}