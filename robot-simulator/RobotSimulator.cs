using System;
using System.Collections.Generic;
public enum Direction
{
    North,
    East,
    South,
    West
}

public class RobotSimulator
{
    private int x;
    private int y;
    private Direction direction;
    public RobotSimulator(Direction direction, int x=0, int y=0)
    {
        this.x = x;
        this.y = y;
        this.direction = direction;
    }

    public Direction Direction
    {

        get
        {
            return direction;
        }
    }

    public int X
    {
        get
        {
            return x;
        }
    }

    public int Y
    {
        get
        {
            return y;
        }
    }

    public void Move(string instructions)
    {
        if (direction == Direction.North)
        {
            switch (instructions)
            {
                case "R":
                    direction = Direction.East;
                    break;
                case "L":
                    direction = Direction.West;
                    break;
                case "A":
                    y++;
                    break;
                default:
                    break;

            }
        }
        else if (direction == Direction.East)
        {
            switch (instructions)
            {
                case "R":
                    direction = Direction.South;
                    break;
                case "L":
                    direction = Direction.North;
                    break;
                case "A":
                    x++;
                    break;
                default:
                    break;

            }
        }
        else if (direction == Direction.South)
        {
            switch (instructions)
            {
                case "R":
                    direction = Direction.West;
                    break;
                case "L":
                    direction = Direction.East;
                    break;
                case "A":
                    y--;
                    break;
                default:
                    break;

            }
        }
        else if (direction == Direction.West)
        {
            switch (instructions)
            {
                case "R":
                    direction = Direction.North;
                    break;
                case "L":
                    direction = Direction.South;
                    break;
                case "A":
                    x--;
                    break;
                default:
                    break;

            }
        }
    }
}