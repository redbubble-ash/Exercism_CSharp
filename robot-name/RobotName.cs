using System;
using System.Collections.Generic;

public class Robot
{
    private readonly static Random rnd = new Random();
    private readonly static List<string> usedName = new List<string>();

    //properties
    public string Name {get;private set;}

    //create a robot
    public Robot()
    {
      Reset();
    }

    //reset the name
    public void Reset()
    {
        Name = GenerateAName();
    }

    //method to generate a name
    private string GenerateAName(){

        string chars = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";
        string rdstr = "";
        // generate random int from 1 to 999
        int newInt = rnd.Next(1,999);
        string finalName = "";

        // check if the name has been used.
        do
	    {
            //genterate random character
            for(int i=0; i<2; i++){
                rdstr+= chars[rnd.Next(26)];
            }

            //join char and int
            finalName = rdstr + String.Format("{0:000}",newInt);


	    } while (usedName.Contains(finalName));

        usedName.Add(finalName);

        return finalName;

    }
}