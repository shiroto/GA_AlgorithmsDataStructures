using UnityEngine;

public class QuickSort : MonoBehaviour
{
    public void Sort()
    {
        int[] arr = new int[] { 2, 5, -4, 11, 0, 18, 22, 67, 51, 6 };

        Debug.Log("Original array : ");
        foreach (int item in arr)
        {
            Debug.Log(" " + item);
        }

        Quick_Sort(arr, 0, arr.Length - 1);

        Debug.Log("Sorted array : ");

        foreach (int item in arr)
        {
            Debug.Log(" " + item);
        }
    }

    private static int Partition(int[] arr, int left, int right)
    {
        int pivot = arr[left];
        while (true)
        {
            while (arr[left] < pivot)
            {
                left++;
            }

            while (arr[right] > pivot)
            {
                right--;
            }

            if (left < right)
            {
                if (arr[left] == arr[right]) return right;

                int temp = arr[left];
                arr[left] = arr[right];
                arr[right] = temp;
            }
            else
            {
                return right;
            }
        }
    }

    private static void Quick_Sort(int[] arr, int left, int right)
    {
        if (left < right)
        {
            int pivot = Partition(arr, left, right);

            if (pivot > 1)
            {
                Quick_Sort(arr, left, pivot - 1);
            }
            if (pivot + 1 < right)
            {
                Quick_Sort(arr, pivot + 1, right);
            }
        }
    }
}
