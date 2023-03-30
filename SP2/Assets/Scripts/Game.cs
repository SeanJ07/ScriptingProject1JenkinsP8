using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Game : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        Player myPlayer = new Player();

        myPlayer.Experience = 5;
        int x = myPlayer.Experience;
    }
}
