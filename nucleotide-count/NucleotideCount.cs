using System;
using System.Collections.Generic;

public static class NucleotideCount
{
    public static IDictionary<char, int> Count(string sequence)
    {
        int a = 0;
        int c = 0;
        int g = 0;
        int t = 0;
        Dictionary<char, int> DNALibrary = new Dictionary<char, int>();
        DNALibrary.Add('A', a);
        DNALibrary.Add('C', c);
        DNALibrary.Add('G', g);
        DNALibrary.Add('T', t);

        char[] characters = sequence.ToCharArray();
        for(int i=0; i < characters.Length; i++)
        {
            switch (characters[i])
            {
                case 'A':
                    a++;
                    DNALibrary['A'] = a;
                    break;
                case 'C':
                    c++;
                    DNALibrary['C'] = c;
                    break;
                case 'G':
                    g++;
                    DNALibrary['G'] = g;
                    break;
                case 'T':
                    t++;
                    DNALibrary['T'] = t;
                    break;
            }
        }

        return DNALibrary;
    }
}