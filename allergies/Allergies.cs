using System;
using System.Collections.Generic;

public enum Allergen
{
    Eggs = 1,
    Peanuts = 2,
    Shellfish = 4,
    Strawberries = 8,
    Tomatoes = 16,
    Chocolate = 32,
    Pollen = 64,
    Cats = 128
}

public class Allergies
{
    private int Score;

    public Allergies(int score)
    {
        this.Score = score;
    }

    public bool IsAllergicTo(Allergen allergen)
    {
        if ((Score & (int)allergen) != 0) return true;
        else return false;
    }

    public List<Allergen> List()
    {
        List<Allergen> newList = new List<Allergen>();
        foreach (int item in Enum.GetValues(typeof(Allergen)))
        {
            if ((Score | item) == Score) newList.Add((Allergen)item);
        }

        return newList;
    }
}

//BitWise Operations in C#:
//https://www.c-sharpcorner.com/article/bitwise-operations-in-C-Sharp/