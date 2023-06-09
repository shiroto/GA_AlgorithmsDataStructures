using System.Text;
using UnityEngine;

public static class ArrayHelper
{
    public static void PrintArray<T>(T[] array)
    {
        StringBuilder sb = new StringBuilder();
        for (int i = 0; i < array.Length; i++)
        {
            sb.Append($"{array[i]},");
        }
        Debug.Log(sb);
    }
}