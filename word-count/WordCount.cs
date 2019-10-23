using System;
using System.Collections.Generic;
using System.Collections;
public static class WordCount
{
    public static IDictionary<string, int> CountWords(string phrase)
    {
        IDictionary<string, int> wordDictionary = new Dictionary<string, int>();
        string[] arr = phrase.Split(" ");
        ArrayList withoutDuplicate = new ArrayList(); 
        for (int i=0; i< arr.Length; i++)
        {
            if(withoutDuplicate.Contains(arr[i]) == false)
            {
                withoutDuplicate.Add(arr[i]);
            }
        }

        int n = 0;
        for (int i = 0; i < withoutDuplicate.Count; i++)
        {
            for(int j = 0; j<arr.Length; j++)
            {
                if (withoutDuplicate[i].ToString() == arr[j]) n++;
            }

            wordDictionary.Add(withoutDuplicate[i].ToString(), n);
            n = 0;
        }
        return wordDictionary;
    }
}