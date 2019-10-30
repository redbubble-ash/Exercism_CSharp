using System;
using System.Collections.Generic;

public enum Plant
{
    Violets,
    Radishes,
    Clover,
    Grass
}

public class KindergartenGarden
{
    private string diagram;

    public KindergartenGarden(string diagram)
    {
        this.diagram = diagram;
    }

    public IEnumerable<Plant> Plants(string student)
    {
        List < string > plantList = new List<string>();
        string rowPoint = "\n";
        int RPIndex = diagram.IndexOf(rowPoint);

        switch (student)
        {
            case "Alice":
                plantList.Add(diagram[0].ToString());
                plantList.Add(diagram[1].ToString());
                plantList.Add(diagram[RPIndex+1].ToString());
                plantList.Add(diagram[RPIndex+2].ToString());
                break;
            case "Bob":
                plantList.Add(diagram[2].ToString());
                plantList.Add(diagram[3].ToString());
                plantList.Add(diagram[RPIndex + 3].ToString());
                plantList.Add(diagram[RPIndex + 4].ToString());
                break;
            case "Charlie":
                plantList.Add(diagram[4].ToString());
                plantList.Add(diagram[5].ToString());
                plantList.Add(diagram[RPIndex + 5].ToString());
                plantList.Add(diagram[RPIndex + 6].ToString());
                break;
            case "David":
                plantList.Add(diagram[6].ToString());
                plantList.Add(diagram[7].ToString());
                plantList.Add(diagram[RPIndex + 7].ToString());
                plantList.Add(diagram[RPIndex + 8].ToString());
                break;
            case "Eve":
                plantList.Add(diagram[8].ToString());
                plantList.Add(diagram[9].ToString());
                plantList.Add(diagram[RPIndex + 9].ToString());
                plantList.Add(diagram[RPIndex + 10].ToString());
                break;
            case "Fred":
                plantList.Add(diagram[10].ToString());
                plantList.Add(diagram[11].ToString());
                plantList.Add(diagram[RPIndex + 11].ToString());
                plantList.Add(diagram[RPIndex + 12].ToString());
                break;
            case "Ginny":
                plantList.Add(diagram[12].ToString());
                plantList.Add(diagram[13].ToString());
                plantList.Add(diagram[RPIndex + 13].ToString());
                plantList.Add(diagram[RPIndex + 14].ToString());
                break;
            case "Harriet":
                plantList.Add(diagram[14].ToString());
                plantList.Add(diagram[15].ToString());
                plantList.Add(diagram[RPIndex + 15].ToString());
                plantList.Add(diagram[RPIndex + 16].ToString());
                break;
            case "Ileana":
                plantList.Add(diagram[16].ToString());
                plantList.Add(diagram[17].ToString());
                plantList.Add(diagram[RPIndex + 17].ToString());
                plantList.Add(diagram[RPIndex + 18].ToString());
                break;
            case "Joseph":
                plantList.Add(diagram[18].ToString());
                plantList.Add(diagram[19].ToString());
                plantList.Add(diagram[RPIndex + 19].ToString());
                plantList.Add(diagram[RPIndex + 20].ToString());
                break;
            case "Kincaid":
                plantList.Add(diagram[20].ToString());
                plantList.Add(diagram[21].ToString());
                plantList.Add(diagram[RPIndex + 21].ToString());
                plantList.Add(diagram[RPIndex + 22].ToString());
                break;
            case "Larry":
                plantList.Add(diagram[22].ToString());
                plantList.Add(diagram[23].ToString());
                plantList.Add(diagram[RPIndex + 23].ToString());
                plantList.Add(diagram[RPIndex + 24].ToString());
                break;


        }

        foreach (string item in plantList)
        {
            switch (item)
            {
                case "V":
                    yield return Plant.Violets;
                    break;
                case "R":
                    yield return Plant.Radishes;
                    break;
                case "C":
                    yield return Plant.Clover;
                    break;
                case "G":
                    yield return Plant.Grass;
                    break;

            }

        }
    }
}