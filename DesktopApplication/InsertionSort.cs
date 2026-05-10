using System;

namespace DesktopApplication
{
    public class InsertionSort
    {
        private int[] array;
        private int i = 1; 
        private int j = 0; 
        private bool isPlacing = false; 

        public InsertionSort(int[] array)
        {
            this.array = array;
        }

        public bool SortStep(out int comparisons)
        {
            comparisons = 0;


            if (i >= array.Length) return false;


            if (j >= 0 && array[j] > array[j + 1])
            {
                comparisons++;

                int temp = array[j];
                array[j] = array[j + 1];
                array[j + 1] = temp;
                j--;
            }
            else
            {

                i++;
                j = i - 1;
            }

            return i < array.Length;
        }
    }
}