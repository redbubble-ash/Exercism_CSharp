using System;
using System.Collections;
using System.Collections.Generic;

public static class ResistorColor
{
    public static int ColorCode(string color)
    {
        return Array.IndexOf(Colors(),color);
    }

    public static string[] Colors()
    {
        ArrayList colorList = new ArrayList();
        colorList.Add("black");
        colorList.Add("brown");
        colorList.Add("red");
        colorList.Add("orange");
        colorList.Add("yellow");
        colorList.Add("green");
        colorList.Add("blue");
        colorList.Add("violet");
        colorList.Add("grey");
        colorList.Add("white");

        return (String[])colorList.ToArray(typeof(string));
    }
}


//public static class ResistorColor
//{
//  public static int ColorCode(string color)
//     => Array.IndexOf(Colors(), color);
//
//    public static string[] Colors()
//       => new[] { "black", "brown", "red", "orange", "yellow", "green", "blue", "violet", "grey", "white" };
//}