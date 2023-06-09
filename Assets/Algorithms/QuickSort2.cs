/*
Quicksort (array, low, high):
Step 1: if low < high
Step 1.1: pivot = Partition(array, low, high)
	Step 1.2: Sort left side -> Quicksort(array, low, pivot - 1)
	Step 1.3: Sort right side -> Quicksort(array, pivot + 1, high)

Partition (array, low, high):
Step 1: Set PIVOT to array[high]
Step 2: Set PARTITION to low
Step 3: For i=low to high-1
	Step 3.1: if array[i] <= pivot -> swap array[i] and array[PARTITION] and increment PARTITION
Step 4: Swap array[PARTITION] and array[high]
Step 5: return PARTITION
*/

public static class QuickSort2
{
    public static void QuickSort(int[] array)
    {
        QuickSort2.QuickSort(array, 0, array.Length - 1);
    }

    private static int Partition(int[] array, int low, int high)
    {
        int pivot = array[high];
        int partition = low;
        for (int i = low; i < high; i++)
        {
            if (array[i] <= pivot)
            {
                (array[i], array[partition]) = (array[partition], array[i]);
                partition++;
            }
        }
        (array[partition], array[high]) = (array[high], array[partition]);
        return partition;
    }

    private static void QuickSort(int[] array, int low, int high)
    {
        if (low < high)
        {
            int pivot = Partition(array, low, high);
            QuickSort(array, low, pivot - 1);
            QuickSort(array, pivot + 1, high);
        }
    }
}