using System.Security.Cryptography.X509Certificates;

namespace SortingTechniques
{
    class Program
    {
        public static void Main(string[] args)
        {
            int[] arr = { 78, 55, 45, 13 };
            int temp;
            for (int i = 0; i <= arr.Length - 2; i++)
            {
                for (int j = 0; j <= arr.Length - 2; j++)
                {
                    if (arr[j] > arr[j + 1])
                    {
                        temp = arr[j + 1];
                        arr[j + 1] = arr[j];
                        arr[j] = temp;
                    }
                }
            }
        Console.WriteLine("Sorted: ");
        foreach (int p in arr)
        {
            Console.WriteLine(p + " ");
        }
            //Insertion
            InsertionSort insertionSort = new InsertionSort();
            insertionSort.InsertionDemo();
            
            //Merge
            MergeSort mergeSort = new MergeSort();
            Console.WriteLine("Given Array");
            foreach (int p in arr)
            {
                Console.WriteLine(p + " ");
            }
            mergeSort.sort(arr, 0, arr.Length - 1);
            Console.WriteLine("\nSorted array");
            foreach (int p in arr)
            {
                Console.WriteLine(p + " ");
            }

            //Anagram
            Anagram anagram = new Anagram();
            anagram.PrintAnagram();

        }
    }
}