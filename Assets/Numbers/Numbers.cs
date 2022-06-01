using System;
using UnityEngine;

public class Numbers : MonoBehaviour
{
    public void PrintDoublePrecision()
    {
        double x = 123456789.987654321;
        Debug.Log(x);
    }

    public void PrintFloatCompare()
    {
        float af = (0.3f * 3) + 0.1f;
        float bf = 1;
        Debug.Log(af);
        Debug.Log(bf);
        Debug.Log(af == bf);
        
        double ad = (0.3 * 3) + 0.1;
        double bd = 1;
        Debug.Log(ad);
        Debug.Log(bd);
        Debug.Log(ad == bd);
        Debug.Log(ad - bd);
    }

    public void PrintFloatingOverflow()
    {
        Debug.Log($"Double: {double.MinValue}—{double.MaxValue}");
        double x = double.MaxValue;
        Debug.Log($"x={x}");
        x += 10000;
        Debug.Log($"x={x}");
        x *= 2;
        Debug.Log($"x={x}");
    }

    public void PrintFloatingRange()
    {
        Debug.Log($"Float: {float.MinValue}—{float.MaxValue}");
        Debug.Log($"Double: {double.MinValue}—{double.MaxValue}");
    }

    public void PrintFloatingUnderflow()
    {
        Debug.Log($"Double: {double.MinValue}—{double.MaxValue}");
        double x = double.MinValue;
        Debug.Log($"x={x}");
        x -= 10000;
        Debug.Log($"x={x}");
        x *= 2;
        Debug.Log($"x={x}");
    }

    public void PrintFloatPrecision()
    {
        float x = 12300000;
        Debug.Log(x);
        x += 45678;
        Debug.Log(x);
        x = x * 10 + 9;
        Debug.Log(x);
        x /= 100000000;
        Debug.Log(x);
        x -= 1;
        Debug.Log(x);
        x -= 0.0000001f;
        Debug.Log(x);
        x += 0.00000009f;
        Debug.Log(x);
        Debug.Log(123456789.987654321f);
    }

    public void PrintOverflow()
    {
        Debug.Log($"Int: {int.MinValue}—{int.MaxValue}");
        int x = int.MaxValue;
        Debug.Log($"x={x}");
        Debug.Log($"x={Convert.ToString(x, 16)}");
        x += 1;
        Debug.Log($"x={x}");
        Debug.Log($"x={Convert.ToString(x, 16)}");
    }

    public void PrintRange()
    {
        Debug.Log($"Byte: {byte.MinValue}—{byte.MaxValue}");
        Debug.Log($"Short: {short.MinValue}—{short.MaxValue}");
        Debug.Log($"Int: {int.MinValue}—{int.MaxValue}");
        Debug.Log($"Long: {long.MinValue}—{long.MaxValue}");

        Debug.Log($"SByte: {sbyte.MinValue}—{sbyte.MaxValue}");
        Debug.Log($"UShort: {ushort.MinValue}—{ushort.MaxValue}");
        Debug.Log($"UInt: {uint.MinValue}—{uint.MaxValue}");
        Debug.Log($"ULong: {ulong.MinValue}—{ulong.MaxValue}");
    }

    public void PrintUnderflow()
    {
        Debug.Log($"Int: {int.MinValue}—{int.MaxValue}");
        int x = int.MinValue;
        Debug.Log($"x={x}");
        Debug.Log($"x={Convert.ToString(x, 16)}");
        x -= 1;
        Debug.Log($"x={x}");
        Debug.Log($"x={Convert.ToString(x, 16)}");
    }
}