using System;
using System.Collections.Generic;
using System.Collections;
using System.Text.RegularExpressions;

public static class WordCount
{
    public static IDictionary<string, int> CountWords(string phrase)
    {
        //[   #Character block start.
        //^   #Not these characters (letters, numbers).
        //\w  #Word characters.
        //\s  #Space characters.
        //]   #Character block end.
        string newPhrase = Regex.Replace(phrase, @"[^\w ']", " ").ToLower();
        Console.WriteLine("Regex output is " + newPhrase);
        //\w?'\w?
        IDictionary<string, int> wordDictionary = new Dictionary<string, int>();


        string[] arr = newPhrase.Split(" ", System.StringSplitOptions.RemoveEmptyEntries);
        ArrayList withoutDuplicate = new ArrayList();
        for (int i = 0; i < arr.Length; i++)
        {
            if (withoutDuplicate.Contains(arr[i]) == false)
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