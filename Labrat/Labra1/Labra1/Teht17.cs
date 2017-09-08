using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Labra1
{
    class Teht17
    {
        static public int Partition(int[] numbers, int left, int right)
        {
            int pivot = numbers[left];
            while (true)
            {
                while (numbers[left] < pivot)
                    left++;

                while (numbers[right] > pivot)
                    right--;

                if (left < right)
                {
                    int tmp = numbers[right];
                    numbers[right] = numbers[left];
                    numbers[left] = tmp;
                }
                else
                {
                    return right;
                }
            }
        }

        static public int[] quickSort(int[] Merged, int left, int right)
        {
            // For Recusrion  
            if (left < right)
            {
                int pivot = Partition(Merged, left, right);

                if (pivot > 1)
                    quickSort(Merged, left, pivot - 1);

                if (pivot + 1 < right)
                    quickSort(Merged, pivot + 1, right);
            }
            return Merged;
        }


        public static int[] Merge(int[] Array1,int[] Array2)
        {
            int[] Merged = new int[Array1.Length + Array2.Length];
            int j;
            j = 0;

            for(int i = 0; i < Array1.Length + Array2.Length; i+=2)
            {
                Merged[i] = Array1[j];
                Merged[i+1] = Array2[j];
                j += 1;
            }
            return Merged;
        }


        public static void SortArrays()
        {
            int[] Merged;
            int[] Sorted;
            int[] Array1 = new int[] {10,20,22,40,33};
            int[] Array2 = new int[] {5,15,54,21,45};

            Merged = Merge(Array1, Array2);

            for(int i = 0; i < Merged.Length; i++)
            {
                Console.WriteLine(Merged[i]);
            }

            Console.WriteLine("Calls Quicksort");
            Sorted = quickSort(Merged, 0, Merged.Length-1);

            for (int i = 0; i < Sorted.Length; i++)
            {
                Console.WriteLine(Sorted[i]);
            }

        }


    }
}
