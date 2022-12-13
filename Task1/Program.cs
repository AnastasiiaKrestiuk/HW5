using System;

namespace Task1
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
                    array[i] = rnd.Next(100, 1000);
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
            int EvenNumbers(int[] array)
            {
                int count = 0;
                for (int i = 0; i < array.Length; i++)
                {
                    if (array[i]%2 == 0)
                    {
                        count++;
                    }
                }
                return count;
            }

            int size = 5;
            int[] array = InitArray(size);
            //PrintArray(array);
            Console.WriteLine(EvenNumbers(array));
        }
    }
}
