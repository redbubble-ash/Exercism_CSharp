using System;

public class Clock
{
    public int hours;
    public int minutes;
    public Clock(int hours, int minutes)
    {

        this.hours = hours;
        this.minutes = minutes;
        clockConvert();
    }

    public void clockConvert()
    {
        int addHours = 0;
        if (minutes >= 60)
        {
            addHours = minutes / 60;
            minutes = minutes % 60;
        }
        if (hours >= 0)
        {
            hours = (hours + addHours) % 24;
        }
        if (minutes < 0)
        {
            if (minutes % 60 == 0)
            {
                addHours = minutes / 60;
                minutes = minutes % 60;
            }
            else
            {
                addHours = minutes / 60 - 1;
                minutes = 60 + minutes % 60;
            }
            hours += addHours;
        }
        if (hours < 0)
        {
            if (hours % 24 == 0) hours = 0;
            else hours = 24 + hours % 24;
        }
    }

    public Clock Add(int minutesToAdd)
    {
        Clock clockAdd = new Clock(hours, minutes);
        int convertToMinutes = clockAdd.hours * 60 + clockAdd.minutes;
        convertToMinutes += minutesToAdd;
        clockAdd.hours = convertToMinutes / 60;
        clockAdd.minutes = convertToMinutes % 60;
        clockAdd.clockConvert();
        return clockAdd;
    }

    public Clock Subtract(int minutesToSubtract)
    {
        Clock clockSubtract = new Clock(hours, minutes);
        int convertToMinutes = clockSubtract.hours * 60 + minutes;
        convertToMinutes -= minutesToSubtract;
        clockSubtract.hours = convertToMinutes / 60;
        clockSubtract.minutes = convertToMinutes % 60;
        clockSubtract.clockConvert();
        return clockSubtract;


    }

    public override string ToString()
    {

        return ($"{String.Format("{0:00}", hours)}:{String.Format("{0:00}", minutes)}");
    }

    public override bool Equals(object obj)
    {
        return this.hours == ((Clock)obj).hours && this.minutes == ((Clock)obj).minutes;
    }
}

//  see https://msdn.microsoft.com/en-us/library/2dts52z7(v=vs.110).aspx
