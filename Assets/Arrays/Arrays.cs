using UnityEngine;

public class Arrays : MonoBehaviour
{
    [SerializeField]
    [Tooltip("Lengths of arrays to benchmark")]
    private int[] lengths;

    [SerializeField]
    [Tooltip("How many times to benchmark each length")]
    private int times;

    public async void BenchmarkArray()
    {
        for (int i = 0; i < lengths.Length; i++)
        {
            int length = lengths[i];
            Debug.Log($"Benchmarking length {length}");
            int target = 38;
            int[] data = CreateRandomArray(length);
            data[length - 1] = target;
            await Benchmark.DoBenchmark(() => FindNumberInByteArray(data, target), times);
        }
    }

    private static int[] CreateRandomArray(int length)
    {
        int[] data = new int[length];
        for (int i = 0; i < length; i++)
        {
            data[i] = UnityEngine.Random.Range(int.MinValue, int.MaxValue);
        }
        return data;
    }

    private static void FindNumberInByteArray(int[] array, int target)
    {
        for (int i = 0; i < array.Length; i++)
        {
            if (array[i] == target)
            {
                break;
            }
        }
    }
}