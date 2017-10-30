using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SortingAlgorithms
{
    internal class BubbleSort : NumberSorter
    {
        public override int[] SortAscending(int[] array)
        {
            for (int i = array.Length - 1; i > 0; --i)
                for (int j = 0; j < i; ++j)
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
