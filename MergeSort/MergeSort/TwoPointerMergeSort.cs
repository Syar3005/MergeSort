using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MergeSort
{
    public class TwoPointerMergeSort
    {
        public static void Sort(int[] arr)
        {
            int[] temp = new int[arr.Length];
            Sort(arr, temp, 0, arr.Length - 1);
        }

        private static void Sort(int[] arr, int[] temp, int left, int right)
        {
            if (left >= right)
                return;

            int middle = (left + right) / 2;

            Sort(arr, temp, left, middle);
            Sort(arr, temp, middle + 1, right);

            Merge(arr, temp, left, middle, right);
        }

        private static void Merge(int[] arr, int[] temp, int left, int middle, int right)
        {
            Array.Copy(arr, left, temp, left, right - left + 1);

            int i = left;
            int j = middle + 1;
            int k = left;

            while (i <= middle && j <= right)
            {
                if (temp[i] <= temp[j])
                {
                    arr[k] = temp[i];
                    i++;
                }
                else
                {
                    arr[k] = temp[j];
                    j++;
                }
                k++;
            }

            while (i <= middle)
            {
                arr[k] = temp[i];
                i++;
                k++;
            }
        }
    }
}
