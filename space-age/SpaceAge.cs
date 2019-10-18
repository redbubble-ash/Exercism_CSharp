using System;

public class SpaceAge
{
    // instance variable
    public double Seconds { get; private set; }

    // constructor
    public SpaceAge(int seconds)
    {
        this.Seconds =  seconds;
    }

    // instance method
    public double OnEarth()
    {
        return  Math.Round(Seconds /31557600, 2);
    }

    public double OnMercury()
    {
        return Seconds /(31557600 * 0.2408467);
    }

    public double OnVenus()
    {
        return Seconds /(31557600 * 0.61519726);
    }

    public double OnMars()
    {
        return Seconds / (31557600 * 1.8808158);
    }

    public double OnJupiter()
    {
        return Seconds / (31557600 * 11.862615);
    }

    public double OnSaturn()
    {
        return Seconds / (31557600 * 29.447498);
    }

    public double OnUranus()
    {
        return Seconds / (31557600 * 84.016846);
    }

    public double OnNeptune()
    {
        return Seconds / (31557600 * 164.79132);
    }
}