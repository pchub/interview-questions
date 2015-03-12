
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;

namespace InterviewQuestions
{
    public static class ArrayQuestions
    {
        public static int[] MergeArrays(int[] a, int[] b)
        {
            var c = new int[a.Length + b.Length];

            int aIndex = 0, bIndex = 0, cIndex = 0;

            while (true)
            {
                if (aIndex < a.Length && bIndex < b.Length)
                {
                    if (a[aIndex] < b[bIndex])
                    {
                        c[cIndex] = a[aIndex];
                        aIndex++;
                    }
                    else if (b[bIndex] <= a[aIndex])
                    {
                        c[cIndex] = b[bIndex];
                        bIndex++;
                    }

                    cIndex++;
                }
                else
                {
                    break;
                }
            }

            if (aIndex < a.Length)
            {
                Copy(a, c, aIndex, cIndex);
            }

            if (bIndex < b.Length)
            {
                Copy(b, c, bIndex, cIndex);
            }

            return c;
        }

        public static int[] MergeMultipleArrays(ICollection<int[]> arrays)
        {
            List<Item> arrayItems = arrays.Select(array => new Item() { Array = array }).ToList();
            int[] mergedArray = new int[arrayItems.Sum(ai => ai.Array.Length)];
            int mergedArrayIndex = 0;
            while (true)
            {
                Item minItem = null;
                for (int i = 0; i < arrayItems.Count; i++)
                {
                    if (!arrayItems[i].IsDone)
                    {
                        if (minItem == null)
                        {
                            minItem = arrayItems[i];
                        }
                        else
                        {
                            if (arrayItems[i].CurrentArrayItem < minItem.CurrentArrayItem)
                            {
                                minItem = arrayItems[i];
                            }
                        }
                    }
                }

                if (minItem == null)
                {
                    break;
                }

                mergedArray[mergedArrayIndex++] = minItem.CurrentArrayItem;
                minItem.MoveForward();
            }

            return mergedArray;
        }

        public static int Partition(int[] input, int pivotIndex)
        {
            int pivot = input[pivotIndex];

            int storeIndex = 0;
            Swap(input, 0, input.Length - 1);

            for (int i = 0; i < input.Length - 1; i++)
            {
                if (input[i] < pivot)
                {
                    Swap(input, storeIndex, i);
                    ++storeIndex;
                }
            }

            Swap(input, storeIndex, input.Length - 1);

            return storeIndex;
        }

        private static void Swap(int[] input, int i, int j)
        {
            int temp = input[i];
            input[i] = input[j];
            input[j] = temp;
        }

        private class Item
        {
            public int[] Array { get; set; }

            public int CurrentPosition { get; private set; }

            public int CurrentArrayItem
            {
                get { return this.Array[this.CurrentPosition]; }
            }

            public void MoveForward()
            {
                this.CurrentPosition = this.CurrentPosition + 1;
            }

            public bool IsDone
            {
                get { return this.CurrentPosition > this.Array.Length - 1; }
            }
        }

        private static void Copy(int[] a, int[] b, int aStartIndex, int bStartIndex)
        {
            for (int i = aStartIndex, j = bStartIndex; i < a.Length; i++, j++)
            {
                b[j] = a[i];
            }
        }
    }
}
