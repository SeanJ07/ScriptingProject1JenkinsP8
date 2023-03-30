using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    private int experience;

    public int Experience
    {
        get
        {
            return experience;
        }

        set
        {
            experience = value;
        }
    }

    public int Level
    {
        get
        {
            return experience / 1000;
        }

        set
        {
            experience = 1000;
        }
    }

    public int Health { get; set; }
}
