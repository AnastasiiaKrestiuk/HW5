using System;

namespace Task3
{
    class Program
    {
        static void Main(string[] args)
        {
            double[] InitArray(int length)
            {
                double[] array = new double[length];
                Random rnd = new Random();
                for (int i = 0; i < array.Length; i++)
                {
                    array[i] = rnd.NextDouble()*((5.0 - (-5.0)) + (-5.0));
                }
                return array;
            }
            void PrintArray(double[] array)
            {
                for (int i = 0; i < array.Length; i++)
                {
                    Console.Write($"{array[i]} ");
                }
            }
            double Difference(double[] array)
            {
                double max = array[0];
                double min = array[0];

                for (int i = 1; i < array.Length; i++)
                {
                    if(max < array[i])
                    {
                        max = array[i];
                    }

                    else if(min > array[i])
                    {
                        min = array[i];
                    }
                }
                return max - min;
            }
            Console.WriteLine("Введите размер массива:");
            int size = int.Parse(Console.ReadLine());
            double[] array = InitArray(size);
            PrintArray(array);
            Console.WriteLine(Difference(array));
        }
    }
}
