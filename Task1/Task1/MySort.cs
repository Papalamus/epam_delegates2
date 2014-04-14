using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1
{
    internal delegate int CompareHandler<T>(T o1, T o2);
    static class  MySort
    {
        public static void sorting<T>(this T[] arr, long first, long last,CompareHandler<T> compare)
        {
            T p = arr[(last - first) / 2 + first];
            T temp;
            long i = first, j = last;
            while (i <= j)
            {
                while (compare(arr[i], p) < 0 && i <= last) ++i;
                while (compare(arr[j], p) > 0 && j >= first) --j;
                if (i <= j)
                {
                    temp = arr[i];
                    arr[i] = arr[j];
                    arr[j] = temp;
                    ++i; --j;
                }
            }
            if (j > first) sorting(arr, first, j,compare);
            if (i < last) sorting(arr, i, last, compare);
        }
    }
}
