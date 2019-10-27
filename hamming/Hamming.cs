using System;

public static class Hamming
{
    public static int Distance(string firstStrand, string secondStrand)
    {
        int distance = 0;
        char[] first = firstStrand.ToCharArray();
        char[] second = secondStrand.ToCharArray();
        if (firstStrand.Length != secondStrand.Length) throw new ArgumentException();
        else
        {
            for(int i=0; i < firstStrand.Length; i++)
            {
                if (first[i] != second[i]) distance++;
            }

            return distance;
        }

    }
}