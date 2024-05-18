using System.Collections;
using System.Diagnostics;

namespace TurboCollections;

public class TurboSearch<T> : IEnumerable<T> where T : IComparable<T>
{
    public int BinarySearch(IList<T> list, T value) 
    {
        
        int left = 0;
        int right = list.Count - 1;
        
        if (!list.Contains(value))
            return -1;

        while (left <= right)
        {
            int mid = left + (right - left) / 2;
            int comparison = list[mid].CompareTo(value);

            if (comparison == 0)
            {
                return mid; // value found
            }
            if (comparison < 0)
            {
                left = mid + 1; // search the right half
            }
            else
            {
                right = mid - 1; // search the left half
            }
        }

        return -2; // value not found
    }

    public IEnumerator<T> GetEnumerator()
    {
        throw new NotImplementedException();
    }

    IEnumerator IEnumerable.GetEnumerator()
    {
        return GetEnumerator();
    }
}