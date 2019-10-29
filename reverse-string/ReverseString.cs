using System;

public static class ReverseString
{
    public static string Reverse(string input)
    {
        char[] newString = input.ToCharArray();
        char temp;
        int i = newString.Length - 1;
        int j = 0;

        do
        {
            if (!string.IsNullOrEmpty(input))
            {
                //for (int i = newString.Length - 1; i < newString.Length; i--)
                temp = newString[j];
                newString[j] = newString[i];
                newString[i] = temp;
                j++;
                i--;
            }
            else break;

        } while (i > j);

        string reverseString = string.Join("", newString);
        return reverseString;

    }
}