using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructure
{
    public class QuickSortAlg
    {
        public void QuickSort(int[] array)
        {
            QuickSort(array, 0, array.Length - 1);
        }

        public void QuickSort(int[] array, int left, int right)
        {
            //9,2,6,4,3,5,1
            if (left >= right) // 9 > 1
            {
                return;
            }

            int pivot = array[(left + right) / 2]; //pivot middle
            int index = Partition(array, left, right, pivot);
            QuickSort(array, left, index - 1);
            QuickSort(array, index, right);
        }

        public int Partition(int[] array, int left, int right, int pivot)
        {
            
            while (left <= right)  
            {
                while(array[left] < pivot)
                {
                    left++;
                }
                while (array[right] > pivot)
                {
                    right--;
                }

                if(left <= right)
                {
                    int auxLeft = left;
                    int auxRight = right;
                    array[left] = auxRight;
                    array[right] = auxLeft;
                    left++;
                    right--;
                }
            }

            return left;
        }
    }
}
