using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GabrielCampbellEAE2420WeekThree
{
    class QuickSort
    {
        public static int Partition(int[] array, int low, int high)
        {
            int i = low;
            int j = high + 1;

            while (true)
            {
                while(array[++i] < array[low])
                {
                    if (i == high)
                        break;
                }

                while (array[low] < array[--j])
                {
                    if (j == low)
                        break;
                }

                if (i >= j)
                    break;
                int temp = array[i];
                array[i] = array[j];
                array[j] = temp; 
            }
            int tempo = array[low];
            array[low] = array[j];
            array[j] = tempo;
            return j;
        }

        public static void Sort(int[] array)
        {
            int low = 0;
            int high = array.Length - 1;
            Sort(array, low, high);
        }

        public static void Sort(int[] array, int low, int high)
        {
            if (high <= low)
                return;
            int j = Partition(array, low, high);
            Sort(array, low, j - 1);
            Sort(array, j + 1, high);
        }
    }
}
