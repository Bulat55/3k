using System;

namespace K_13
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] heights = new int[3];
            for (int i = 0; i < 3; i++) 
            {
                heights[i] = Convert.ToInt32(Console.ReadLine());
            }
            int[] reversedSorted = heights.OrderByDescending(x => x).ToArray();

            for (int i = 0; i < reversedSorted.Length; i++) 
            {
                Console.WriteLine(reversedSorted[i]);
            }
        }
    }
}