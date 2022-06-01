using System;
using UnityEngine;

public class MergeSort : MonoBehaviour
{
    public void Sort()
    {
        int[] array = { 12, 11, 13, 5, 6, 7 };
        Debug.Log("Given Array");
        ArrayHelper.PrintArray(array);
        DoMergeSort(array, 0, array.Length - 1);
        Console.WriteLine("\nSorted array");
        ArrayHelper.PrintArray(array);
    }

    // Main function that
    // sorts arr[l..r] using
    // merge()
    private void DoMergeSort(int[] arr, int left, int right)
    {
        if (left < right)
        {
            // Find the middle
            // point
            int m = left + (right - left) / 2;

            // Sort first and
            // second halves
            DoMergeSort(arr, left, m);
            DoMergeSort(arr, m + 1, right);

            // Merge the sorted halves
            merge(arr, left, m, right);
        }
    }

    // Merges two subarrays of []arr.
    // First subarray is arr[l..m]
    // Second subarray is arr[m+1..r]
    private void merge(int[] arr, int l, int m, int r)
    {
        // Find sizes of two
        // subarrays to be merged
        int n1 = m - l + 1;
        int n2 = r - m;

        // Create temp arrays
        int[] L = new int[n1];
        int[] R = new int[n2];
        int i, j;

        // Copy data to temp arrays
        for (i = 0; i < n1; ++i)
            L[i] = arr[l + i];
        for (j = 0; j < n2; ++j)
            R[j] = arr[m + 1 + j];

        // Merge the temp arrays

        // Initial indexes of first
        // and second subarrays
        i = 0;
        j = 0;

        // Initial index of merged
        // subarray array
        int k = l;
        while (i < n1 && j < n2)
        {
            if (L[i] <= R[j])
            {
                arr[k] = L[i];
                i++;
            }
            else
            {
                arr[k] = R[j];
                j++;
            }
            k++;
        }

        // Copy remaining elements
        // of L[] if any
        while (i < n1)
        {
            arr[k] = L[i];
            i++;
            k++;
        }

        // Copy remaining elements
        // of R[] if any
        while (j < n2)
        {
            arr[k] = R[j];
            j++;
            k++;
        }
    }
}