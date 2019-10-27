using System;
using System.Collections.Generic;
using System.Linq;

public class HighScores
{
    List<int> scoresList;

    public HighScores(List<int> list)
    {
        scoresList = list;
    }

    public List<int> Scores()
    {
        return scoresList;
    }

    public int Latest()
    {
        return scoresList[scoresList.Count() - 1];
    }

    public int PersonalBest()
    {
        int highestScore = scoresList[0];
        for (int i = 0; i < scoresList.Count() - 1; i++)
        {
            if (scoresList[i + 1] > scoresList[i])
            {
                highestScore = scoresList[i + 1];
            }
        }
        return highestScore;

    }

    //sort an arr in descending order
    public void SortArr(List<int> arr)
    {
        int temp = 0;

        for (int i = 0; i < arr.Count() - 1; i++)
        {
            for (int j = arr.Count() - 1; j > i; j--)
            {
                if (arr[j] > arr[j - 1])
                {
                    temp = arr[j - 1];
                    arr[j - 1] = arr[j];
                    arr[j] = temp;
                }
            }
        }

    }
    public List<int> PersonalTopThree()
    {

        List<int> threeSortedArr = new List<int>();

        if (scoresList.Count() > 3)
        {
            for (int i = 0; i < 3; i++)
            {
                threeSortedArr.Add(scoresList[i]);
            }

            SortArr(threeSortedArr);

            for (int i = 3; i < scoresList.Count(); i++)
            {
                if (scoresList[i] > threeSortedArr[2])
                {
                    threeSortedArr[2] = scoresList[i];
                    SortArr(threeSortedArr);
                }

            }
        }
        else
        {
            for (int i = 0; i < scoresList.Count(); i++)
            {
                threeSortedArr.Add(scoresList[i]);
            }
            SortArr(threeSortedArr);
        }

        return threeSortedArr;
    }
}

//Different ways to sort an array in descending order in C#
//https://www.geeksforgeeks.org/different-ways-to-sort-an-array-in-descending-order-in-c-sharp/
//can use myList.sort() which will sort the myList items in ascending order.
//A trick for sorting the List<T> in descending order is using the reverse() method.
//https://www.jquery-az.com/c-sharp-list-sort/