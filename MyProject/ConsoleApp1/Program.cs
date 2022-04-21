using System;

namespace ConsoleApp1
{
    class Program
    {
        static void CreateArray(ref int [] arr, int size)
        {
            Random random = new Random();
            for (int i = 0; i < size; i++)
            {
                arr[i] = random.Next(1, 10);
            }
            for (int i = 0; i < size; i++)
            {
                Console.Write(arr[i] + " ");
            }
        }
        static void Resize(ref int [] arr, int newSize)
        {
            var newArr = new int[newSize];
            if (newSize > arr.Length)            
            {
                for (int i = 0; i < arr.Length; i++)
                {
                    newArr[i] = arr[i];
                }
            }
            else
            {
                for (int i = 0; i < newSize; i++)
                {
                    newArr[i] = arr[i];
                }
            }
            for (int i = 0; i < newSize ; i++)
            {
                Console.Write(newArr[i] + " ");
            }
        }
        static void Main(string[] args)
        {
            int n = Convert.ToInt32(Console.ReadLine());
            int [] array = new int[n];
            CreateArray(ref array, n);
            Console.WriteLine();
            int newSize = Convert.ToInt32(Console.ReadLine());
            Resize(ref array, newSize);
        }
    }
}
