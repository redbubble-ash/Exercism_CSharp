using System;

public static class DifferenceOfSquares
{
    public static int CalculateSquareOfSum(int max)
    {
        int squareOfSum = 0;
        for (int i = 0; i <= max; i++)
        {
            squareOfSum += i;
        }
        return (int)Math.Pow(squareOfSum, 2);
    }

    public static int CalculateSumOfSquares(int max)
    {
        int sumOfSquares = 0;
        for (int i = 0; i <= max; i++)
        {
            sumOfSquares += (int)Math.Pow(i, 2);
        }

        return sumOfSquares;
    }

    public static int CalculateDifferenceOfSquares(int max)
    {
        return CalculateSquareOfSum(max) - CalculateSumOfSquares(max);
    }
}