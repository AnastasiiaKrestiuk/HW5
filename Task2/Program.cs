using System;

namespace Task2
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] InitArray(int length)
            {
                int[] array = new int[length];
                Random rnd = new Random();
                for (int i = 0; i < array.Length; i++)
                {
                    array[i] = rnd.Next(1, 50);
                }
                return array;
            }
            void PrintArray(int[] array)
            {
                for (int i = 0; i < array.Length; i++)
                {
                    Console.Write($"{array[i]} ");
                }
            }

            int Sum(int[] array)
            {
                int result = 0;
                for (int i = 1; i < array.Length; i += 2)
                {
                    result += array[i];
                }
                return result;
            }

            int size = 5;
            int[] array = InitArray(size);
            //PrintArray(array);
            Console.WriteLine(Sum(array));
        }
    }
}
