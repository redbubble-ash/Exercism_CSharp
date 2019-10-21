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
        Clock clockAdd = new Clock(Hours, Minutes);
        int convertToMinutes = clockAdd.Hours * 60 + clockAdd.Minutes;
        convertToMinutes += minutesToAdd;
        clockAdd.Hours = convertToMinutes / 60;
        clockAdd.Minutes = convertToMinutes % 60;
        return clockAdd;
    }

    public Clock Subtract(int minutesToSubtract)
    {
        Clock clockSubtract = new Clock(Hours, Minutes);
        int convertToMinutes = clockSubtract.Hours * 60 + Minutes;
        convertToMinutes -= minutesToSubtract;
        clockSubtract.Hours = convertToMinutes / 60;
        clockSubtract.Minutes = convertToMinutes % 60;
        return clockSubtract;


    }

    public override string ToString()
    {
        int addHours = 0;
        if (Minutes >= 60)
        {
            addHours = Minutes / 60;
            Minutes = Minutes % 60;
        }
        if (Hours >= 0)
        {
            Hours = (Hours + addHours) % 24;
        }
        if (Minutes < 0)
        {
            if (Minutes % 60 == 0)
            {
                addHours = Minutes / 60;
                Minutes = Minutes % 60;
            }
            else
            {
                addHours = Minutes / 60 - 1;
                Minutes = 60 + Minutes % 60;
            }
            Hours += addHours;
        }
        if (Hours < 0)
        {
            Hours = 24 + Hours % 24;
        }

        return ($"{String.Format("{0:00}", Hours)}:{String.Format("{0:00}", Minutes)}");
    }
}