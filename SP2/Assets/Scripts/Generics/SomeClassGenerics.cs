using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SomeClassGenerics : MonoBehaviour
{
    public T GenericMethod<T>(T param)
    {
        return param;
    }
}
