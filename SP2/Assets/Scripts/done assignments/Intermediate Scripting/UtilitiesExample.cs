using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UtilitiesExample : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        //You can access a static method by using the class name
        //and the dot operator.
        int x = Utilities.Add(5, 6);
    }
}
