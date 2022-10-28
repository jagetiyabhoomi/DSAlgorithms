using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SortingTechniques
{
    public class InsertionSort
    {
        public void InsertionDemo()
        {
            int[] arr = { 78, 55, 45, 13 };
            int n = 4, i, j, val, flag;
            Console.WriteLine("Insertion Sort");
            for(i = 0; i <n; i++)
            {
                Console.WriteLine(arr[i]);
            }
            for(i = 1; i < n; i++)
            {
                val= arr[i];
                flag = 0;
                for(j=i-1; j>=0&& flag!=1;)
                {
                    if (val < arr[j])
                    {
                        arr[j+1] = arr[j];
                        j--;
                        arr[j+1] = val;

                    }
                    else
                    {
                        flag = 1;
                    }

                }
            }
            Console.WriteLine("Sorted Array");
            for(i=0;i<n;i++)
            {
                Console.WriteLine(arr[i] + " ");
            }
         }       

    }
}
