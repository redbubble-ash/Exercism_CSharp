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

//public static string Reverse(string input)
//{
//    var builder = new StringBuilder();

//    foreach (char c in input)
//    {
//        builder.Insert(0, c); //the character was inserted at the first position of the string builder.
//    }

//    return builder.ToString();
//}