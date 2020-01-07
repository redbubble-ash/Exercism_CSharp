using System;

public static class CollatzConjecture
{
    public static int Steps(int number)
    {
        int steps = 0;
        if (number <= 0 )
        {
            throw new ArgumentException();
        }
        else
        {
            while (number != 1)
            {
                switch (number % 2)
                {
                    case 0:
                        number = number / 2;
                        break;
                    case 1:
                        number = 3 * number + 1;
                        break;

                }

                steps++;
            }
        }

        return steps;
    }
    
}