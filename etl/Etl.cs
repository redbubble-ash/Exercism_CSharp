using System;
using System.Collections.Generic;

public static class Etl
{
    public static Dictionary<string, int> Transform(Dictionary<int, string[]> old)
    {
        Dictionary<string, int> newDictionary = new Dictionary<string, int>();
        foreach (var element in old)
        {
            for (int i = 0; i < element.Value.Length; i++)
            {
                newDictionary[element.Value[i].ToLower()] = element.Key;
            }


        }

        
        return newDictionary;


    }
}