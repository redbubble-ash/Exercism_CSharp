using System;
using System.Collections.Generic;
using System.Collections;
using System.Text.RegularExpressions;

public static class WordCount
{
    public static IDictionary<string, int> CountWords(string phrase)
    {
        //\w  #matches any word character (equal to [a-zA-Z0-9_])
        //+   #Matches the preceding character one or more times. For example, "\w+" matches mutiple characters without break (ie. a word).
        //()  #matches a pattern
        //'\w+   #matches ' and followed by mutiple characters, eg 'tttt
        //?   #means optional(can either exisit or not), this case checks to see if there is a patter with ('\w+) after a word. eg Don't: (Dont) + ('t)
        // MatchCollection collects the matched parts of string.
        MatchCollection matchPattern = Regex.Matches(phrase, @"\w+('\w+)?");

        //build an arr which stores all words including the duplicates
        List<string> arr = new List<string>();

        foreach (var match in matchPattern)
        {
            arr.Add(match.ToString().ToLower());
        }

        IDictionary<string, int> wordDictionary = new Dictionary<string, int>();

        //remove all empty spaces
        // string[] arr = newPhrase.Split(" ", System.StringSplitOptions.RemoveEmptyEntries);

        ArrayList uniqeWords = new ArrayList();
        //remove the duplicated words
        for (int i = 0; i < arr.Count; i++)
        {
            if (uniqeWords.Contains(arr[i]) == false)
            {
                uniqeWords.Add(arr[i]);
            }
        }

        int n = 0;
        for (int i = 0; i < uniqeWords.Count; i++)
        {
            for (int j = 0; j < arr.Count; j++)
            {
                if (uniqeWords[i].ToString() == arr[j]) n++;
            }

            wordDictionary.Add(uniqeWords[i].ToString(), n);
            n = 0;
        }
        return wordDictionary;
    }
}