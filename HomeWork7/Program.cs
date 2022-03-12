using System;
using ClassLibrary;

namespace HomeWork7
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] array = new int[6];
            int[,] twoDimensionalArray = new int[3, 3]
            {
                {9881,2,45 },
            
                {4,5,6 },
            
                {458,548,4454 },
            };
            for (int i = 0; i < array.Length; i++)
            {
                Console.Write($"Введите {i + 1} элемент - ");
                array[i] = int.Parse(Console.ReadLine());
            }
            FirstArray.Sort(array);

            foreach (var item in array)
            {
                Console.Write(item + " ");
            }
            Console.WriteLine();

            int[] maxValues = SecondArray.Max(twoDimensionalArray);
            for (int  i = 0; i < maxValues.Length; i++)
            {
                Console.WriteLine($"В строке {i+1} маскисальный {maxValues[i]} ");

            }
            
            
            
        }
    }
}
