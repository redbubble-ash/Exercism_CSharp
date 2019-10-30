using System;
using System.Collections.Generic;

public static class AccumulateExtensions
{
    public static IEnumerable<U> Accumulate<T, U>(this IEnumerable<T> collection, Func<T, U> func)
    {
        Func<T, U> doSomething = func;
        foreach (var item in collection)
        {
            yield return doSomething(item); //yield return it’s not returning a list, but a promise to return a sequence of numbers when asked for it (more concretely, it exposes an iterator to allow us to act on that promise).

}


        //it equivalents to yield return but RETURN A LIST!
        //List<U> newList = new List<U>();
        //Func<T, U> doSomething = func;

        //    foreach (T number in collection)
        //    {
        //        newSqureList.Add(doSomething(number));
        //    }
            
        //    return newList;



    }
}