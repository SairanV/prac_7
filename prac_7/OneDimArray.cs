using System;

internal class OneDimArray
{
    private int[] array;

    public OneDimArray(int[] arr)
    {
        array = arr;
    }

    public int this[int index]
    {
        get { return array[index]; }
        set { array[index] = value; }
    }

    public static int operator *(OneDimArray a, OneDimArray b)
    {
        if (a.array.Length != b.array.Length)
        {
            throw new InvalidOperationException("Arrays must have the same length for multiplication.");
        }

        int result = 0;
        for (int i = 0; i < a.array.Length; i++)
        {
            result += a.array[i] * b.array[i];
        }

        return result;
    }

    public static bool operator ==(OneDimArray a, OneDimArray b)
    {
        if (a.array.Length != b.array.Length)
            return false;

        for (int i = 0; i < a.array.Length; i++)
        {
            if (a.array[i] != b.array[i])
                return false;
        }

        return true;
    }

    public static bool operator !=(OneDimArray a, OneDimArray b)
    {
        return !(a == b);
    }

    public static bool operator <=(OneDimArray a, OneDimArray b)
    {
        if (a.array.Length != b.array.Length)
        {
            throw new InvalidOperationException("Arrays must have the same length for comparison.");
        }

        int sumA = 0;
        int sumB = 0;

        for (int i = 0; i < a.array.Length; i++)
        {
            sumA += a.array[i];
            sumB += b.array[i];
        }

        return sumA <= sumB;
    }

    public static bool operator >=(OneDimArray a, OneDimArray b)
    {
        return b <= a;
    }
}
