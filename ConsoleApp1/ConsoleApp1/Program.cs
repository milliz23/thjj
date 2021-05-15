using System;
using System.Linq;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] array = { 10, 45, -5, 12, 31, -12, 6, 58, 78, 455, 99, 32, 0, 45, 12}; 
            int min = Max(array);
            Console.Write("Минимальны эл.массива: " + min);
            Console.ReadKey(true);
        }
        static int Max(int[] array)
        {
            int min = array[0];
            for (int i = 0; i < array.Count(); i++)
            {
                if (min > array[i])
                {
                    min = array[i];
                }
            }
            return min;
        }
    }
}
