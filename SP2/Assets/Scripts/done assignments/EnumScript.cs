using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnumScript : MonoBehaviour
{
    enum Direction { North, East, South, West };


    void Start()
    {
        Direction dir;

        dir = Direction.North;
        Debug.Log("the direction im looking at is " + dir);
        Debug.Log("the opposite of my direction is " + ReverseDirection (dir));
    }

    Direction ReverseDirection(Direction dir)
    {
        if (dir == Direction.North)
            dir = Direction.South;
        else if (dir == Direction.South)
            dir = Direction.North;
        else if (dir == Direction.East)
            dir = Direction.West;
        else if (dir == Direction.West)
            dir = Direction.East;

        return dir;
    }
}
