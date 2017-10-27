using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SortingAlgorithms
{
    public static class BubbleSort
    {
        public static int[] SortAscending(int[] array)
        {
            for (int i = array.Length - 1; i >= 1; --i)
                for (int j = 1; j <= i - 1; ++j)
                    if (array[j] > array[j+1])
                    {
                        var temp = array[j+1];
                        array[j + 1] = array[j];
                        array[j] = temp;
                    }

            return array;
        }
    }
}
