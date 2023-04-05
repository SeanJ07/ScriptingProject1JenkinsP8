using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StaticGame : MonoBehaviour
{
    void Start()
    {
        Enemy enemy1 = new Enemy();
        Enemy enemy2 = new Enemy();
        Enemy enemy3 = new Enemy();

        //You can access a static variable by using the class name
        //and the dot operator.
        int x = Enemy.enemyCount;
    }
}
