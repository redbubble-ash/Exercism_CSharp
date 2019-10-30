using System;

public static class Series
{
    public static string[] Slices(string numbers, int sliceLength)
    {
        int n = numbers.Length - sliceLength + 1;
        string[] newString = new string[n];

        if (sliceLength <= numbers.Length && sliceLength > 0 && !String.IsNullOrEmpty(numbers))
        {
            for (int i = 0; i < n; i++)
            {
                newString[i] = numbers.Substring(i, sliceLength);
            }

        }
        else throw new ArgumentException();


        return newString;
    }
}