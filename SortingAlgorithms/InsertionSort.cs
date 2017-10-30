using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SortingAlgorithms
{
    internal class InsertionSort : NumberSorter
    {
        public override int[] SortAscending(int[] array)
        {
            var result = new int[array.Length];

            for (int i = 0; i < array.Length; ++i)
            {
                result[i] = array[i];
                
                for (int j = i; j > 0; --j)
                {
                    if (result[j] >= result[j-1])
                        break;

                    var temp = result[j-1];
                    result[j-1] = result[j];
                    result[j] = temp;
                }
            }

            return result;
        }
    }
}
