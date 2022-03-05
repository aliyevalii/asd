using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            #region
            int[] array = { 5, 2, 3, 10, -2 };
            int min = array[0];
            for (int i = 1; i < array.Length; i++)
            {
                if (min > array[i])
                {
                    min = array[i];
                }

            }
            Console.WriteLine(min);
            #endregion


        }
    }
}
