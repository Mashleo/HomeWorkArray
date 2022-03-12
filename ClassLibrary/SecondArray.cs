using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary
{
    public class SecondArray
    {

        public static int[] Max(int[,] array)
        {
            int[] arrayWithMaxElement = new int[array.GetLength(0)];

            for (int i = 0; i < array.GetLength(0); i++)
            {
                
                int max = array[i,0];
           
                for (int  j = 1; j < array.GetLength(1); j++)
                    {
                    
                        if (array[i,j] > max)
                        {
                            max = array[i,j];
                        
                        }    
                    }
                arrayWithMaxElement[i] = max;
                
            }
            return arrayWithMaxElement;
        }
       
    }
}
