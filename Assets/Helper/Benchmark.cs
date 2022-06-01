using System;
using System.Diagnostics;
using System.Threading.Tasks;

public static class Benchmark
{
    public static async Task DoBenchmark(Action action, int times)
    {
        Stopwatch stopwatch = Stopwatch.StartNew();
        for (int i = 0; i < times; i++)
        {
            await Task.Run(action);
        }
        stopwatch.Stop();
        UnityEngine.Debug.Log($"Average of {stopwatch.ElapsedMilliseconds / times}ms");
    }

    public static async Task DoBenchmark<T>(Func<T> action)
    {
        Stopwatch stopwatch = Stopwatch.StartNew();
        T res = await Task.Run(action);
        stopwatch.Stop();
        UnityEngine.Debug.Log($"Found {res} in {stopwatch.ElapsedMilliseconds}ms");
    }
}