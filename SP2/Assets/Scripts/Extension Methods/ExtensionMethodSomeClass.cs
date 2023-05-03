using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ExtensionMethodSomeClass : MonoBehaviour
{
    void Start()
    {
        //Notice how you pass no parameter into this
        //extension method even though you had one in the
        //method declaration. The transform object that
        //this method is called from automatically gets
        //passed in as the first parameter.
        transform.ResetTransformation();
    }
}