using System;
using System.Collections.Generic;

public static class AccumulateExtensions
{
    public static IEnumerable<U> Accumulate<T, U>(this IEnumerable<T> collection, Func<T, U> func)
    {
        List<U> newSqureList = new List<U>();
        Func<T, U> squareResult = func;

            foreach (T number in collection)
            {
                newSqureList.Add(squareResult(number));
            }
            
            return newSqureList;



    }
}