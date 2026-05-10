using System;
using System.Collections.Generic;

namespace DesktopApplication
{
    public class QuickSort
    {
        private Stack<(int low, int high)> stack = new Stack<(int, int)>();
        private int[] array;

        public QuickSort(int[] array)
        {
            this.array = array;
            // Initialize the stack with the full array range
            stack.Push((0, array.Length - 1));
        }

        // This method performs ONE partition step and returns true if still sorting
        public bool SortStep(out int comparisons)
        {
            comparisons = 0;
            if (stack.Count == 0) return false;

            var (low, high) = stack.Pop();

            if (low < high)
            {
                int p = Partition(low, high, ref comparisons);
                // Push right side then left side to stack
                stack.Push((p + 1, high));
                stack.Push((low, p));
            }

            return stack.Count > 0;
        }

        private int Partition(int low, int high, ref int comps)
        {
            int pivot = array[low];
            int i = low - 1;
            int j = high + 1;

            while (true)
            {
                do { i++; comps++; } while (array[i] < pivot);
                do { j--; comps++; } while (array[j] > pivot);

                if (i >= j) return j;

                // Swap elements
                int temp = array[i];
                array[i] = array[j];
                array[j] = temp;
            }
        }
    }
}