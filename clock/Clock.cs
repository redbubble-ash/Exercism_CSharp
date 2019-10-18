using System;

public class Clock
{
    public int Hours;
    public int Minutes;
    public Clock(int hours, int minutes)
    {
        this.Hours = hours;
        this.Minutes = minutes;

    }


    public Clock Add(int minutesToAdd)
    {
        Clock clockAdd = new Clock(Hours,Minutes);
        int convertToMinutes = Hours * 60;
        convertToMinutes += minutesToAdd;
        Hours = convertToMinutes / 60;
        Minutes = convertToMinutes % 60;
        return clockAdd;
    }

    public Clock Subtract(int minutesToSubtract)
    {
        Clock clockSubtract = new Clock(Hours,Minutes);
        int convertToMinutes = Hours * 60;
        convertToMinutes -= minutesToSubtract;
        Hours = convertToMinutes / 60;
        Minutes = convertToMinutes % 60;
        return clockSubtract;


    }

    public override string ToString()
    {
        return ($"{String.Format("{0:00}", Hours)}:{String.Format("{0:00}", Minutes)}");
    }
}