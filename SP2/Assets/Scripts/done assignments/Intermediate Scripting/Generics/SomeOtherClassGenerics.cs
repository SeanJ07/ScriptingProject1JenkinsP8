using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SomeOtherClassGenerics : MonoBehaviour
{
    void Start()
    {
        SomeClassGenerics myClass = new SomeClassGenerics();

        //In order to use this method you must
        //tell the method what type to replace
        //'T' with.
        myClass.GenericMethod<int>(5);
    }
}
