namespace K_12
{
    internal class Program
    {
        static void Main()
        {
            int[] ar = new int[3];
            for (int i = 0; i < 3; i++)
            {
                ar[i] = Convert.ToInt32(Console.ReadLine());
            }
            int step1 = ar[0] + ar[1];
            int step2 = ar[1] + ar[2];
            if (step1 < step2) Console.WriteLine(step2 + "" + step1);
            else Console.WriteLine(step1  + "" + step2);
        }
    }
}