using UnityEngine;

public class BinarySearch : MonoBehaviour
{
    private int[] array;

    public void SearchIterative()
    {
        InitArray();
        int x = 10;
        int result = BinarySearchIterative(array, x);
        if (result == -1)
        {
            Debug.Log("Element not present");
        }
        else
        {
            Debug.Log("Element found at index " + result);
        }
    }

    public void SearchRecursive()
    {
        InitArray();
        int x = 10;
        int result = DoBinarySearchRecursive(array, 0, array.Length - 1, x);
        if (result == -1)
        {
            Debug.Log("Element not present");
        }
        else
        {
            Debug.Log("Element found at index " + result);
        }
    }

    /// <summary>
    /// Iterative binary search.
    /// </summary>
    /// <param name="array">Array to search.</param>
    /// <param name="x">The value we search for.</param>
    /// <returns>Position of the value or -1 if not present.</returns>
    private static int BinarySearchIterative(int[] array, int x)
    {
        int left = 0;
        int right = array.Length - 1;
        while (left <= right)
        {
            int m = left + (right - left) / 2;

            // Check if x is present at mid
            if (array[m] == x)
            {
                return m;
            }

            // If x greater, ignore left half
            if (array[m] < x)
            {
                left = m + 1;
            }

            // If x is smaller, ignore right half
            else
            {
                right = m - 1;
            }
        }

        // if we reach here, then element was
        // not present
        return -1;
    }

    /// <summary>
    /// Returns index of x if it is present in
    /// arr[l..r], else return -1
    /// </summary>
    private static int DoBinarySearchRecursive(int[] array, int left, int right, int x)
    {
        if (right >= left)
        {
            int mid = left + (right - left) / 2;

            // If the element is present at the
            // middle itself
            if (array[mid] == x)
            {
                return mid;
            }

            // If element is smaller than mid, then
            // it can only be present in left subarray
            if (array[mid] > x)
            {
                return DoBinarySearchRecursive(array, left, mid - 1, x);
            }

            // Else the element can only be present
            // in right subarray
            return DoBinarySearchRecursive(array, mid + 1, right, x);
        }

        // We reach here when element is not present
        // in array
        return -1;
    }

    private void InitArray()
    {
        array = new int[] { 2, 3, 4, 10, 40 };
    }
}