using System;

namespace ClassLibrary
{
    public class FirstArray
    {
       
        public  static int[] Sort(int[] array)
        {
            for (int i = 0; i < array.Length; i++)
            {
                for (int j = 1; j < array.Length; j++)
                {
                    if (array[j] > array[j - 1])
                    {
                        int temp = array[j - 1];
                        array[j - 1] = array[j];
                        array[j] = temp;

                    }

                }

            }

            return array;
        }

    }
}
