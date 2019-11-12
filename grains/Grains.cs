using System;
using System.IO;

public static class Grains
{
    //"Ulong is unsigned 64-bit integer type data type which is derived from System.UInt64 Class. 
    //It stores value between 0 to 18,446,744,073,709,551,615. 
    //It is used for storing very large number."

    static ulong[] square = new ulong[64];

    public static ulong Square(int n)
    {
        square[0] = 1;

        for (int i = 1; i < 64; i++)
        {
            square[i] = square[i - 1] * 2;
        }

        if (n > 0 && n<= 64)
        {
            return (ulong)square[n - 1];
        }
        else
        {
            throw new ArgumentOutOfRangeException();
        }
    }

    public static ulong Total()
    {
        ulong sum = 0;
        for (int i = 0; i < square.Length ; i++)
        {
            sum += (ulong)square[i];

        }
        return sum;

    }
}