using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterviewQuestions
{
    public static class SortingQuestions
    {
        public static void BubbleSort(int[] input)
        {
            for (int j = input.Length - 1; j > 0; --j)
            {
                for (int i = 0; i < j; i++)
                {
                    if (input[i] > input[i + 1])
                    {
                        int temp = input[i];
                        input[i] = input[i + 1];
                        input[i + 1] = temp;
                    }
                }
            }
        }

        public static void InsertionSort(int[] input)
        {
            for (int j = 1; j < input.Length; j++)
            {
                for (int i = j; i > 0 && input[i] < input[i - 1]; --i)
                {
                    int temp = input[i];
                    input[i] = input[i - 1];
                    input[i - 1] = temp;
                }
            }
        }

        public static void SelectionSort(int[] input)
        {
            for (int j = 0; j < input.Length - 1; j++)
            {
                int smallest = input[j];
                int smallestIndex = j;
                for (int i = j + 1; i < input.Length; i++)
                {
                    if (input[i] < smallest)
                    {
                        smallest = input[i];
                        smallestIndex = i;
                    }
                }

                int temp = input[j];
                input[j] = input[smallestIndex];
                input[smallestIndex] = temp;
            }
        }

        public static void MergeSort(int[] input)
        {
            
        }

        public static void QuickSort(int[] input)
        {
            QuickSort(input, 0, input.Length - 1);
        }

        private static void QuickSort(int[] input, int lo, int hi)
        {
            if (lo < hi)
            {
                int p = Partition(input, lo, hi);
                QuickSort(input, lo, p - 1);
                QuickSort(input, p + 1, hi);
            }
        }

        private static int Partition(int[] input, int lo, int hi)
        {
            int pivotIndex = lo;
            int pivotValue = input[pivotIndex];
            // put the chosen pivot at A[hi]
            Swap(input, pivotIndex, hi);

            int storeIndex = lo;

            // Compare remaining array elements against pivotValue = A[hi]
            for (int i = lo; i < hi; i++)
            {
                if (input[i] < pivotValue)
                {
                    Swap(input, i, storeIndex);
                    storeIndex++;
                }
            }

            Swap(input, storeIndex, hi);
            return storeIndex;
        }

        private static void Swap(int[] input, int i, int j)
        {
            int temp = input[i];
            input[i] = input[j];
            input[j] = temp;
        }
    }
}
