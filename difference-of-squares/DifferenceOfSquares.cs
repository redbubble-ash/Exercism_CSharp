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

//using LINQ Query: Enumerable.Range & Enumerable.Sum()
//class Squares
//{
//    private IEnumerable<int> range;

//    public Squares(int n) { range = Enumerable.Range(1, n); } // a collection/list from 1 through n, eg: n=10, {1, 2, 3, 4, 5, 6, 7, 8, 9, 10}

//    public int SumOfSquares() => range.Sum(x => x * x);

//    public int SquareOfSums() => (int)Math.Pow(range.Sum(), 2);

//    public int DifferenceOfSquares() => SquareOfSums() - SumOfSquares();
//}