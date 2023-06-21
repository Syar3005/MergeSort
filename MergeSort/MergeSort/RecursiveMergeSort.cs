using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MergeSort
{
    public class RecursiveMergeSort
    {
        public static void Sort(int[] arr)
        {
            if (arr.Length <= 1)
                return;

            int middle = arr.Length / 2;
            int[] left = new int[middle];
            int[] right = new int[arr.Length - middle];

            Array.Copy(arr, 0, left, 0, middle);
            Array.Copy(arr, middle, right, 0, arr.Length - middle);

            Sort(left);
            Sort(right);

            Merge(arr, left, right);
        }

        private static void Merge(int[] arr, int[] left, int[] right)
        {
            int i = 0, j = 0, k = 0;

            while (i < left.Length && j < right.Length)
            {
                if (left[i] <= right[j])
                {
                    arr[k] = left[i];
                    i++;
                }
                else
                {
                    arr[k] = right[j];
                    j++;
                }
                k++;
            }

            while (i < left.Length)
            {
                arr[k] = left[i];
                i++;
                k++;
            }

            while (j < right.Length)
            {
                arr[k] = right[j];
                j++;
                k++;
            }
        }
    }
}
