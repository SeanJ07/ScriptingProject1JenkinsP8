using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GenericClass : MonoBehaviour
{
    T item;

    public void UpdateItem(T newItem)
    {
        item = newItem;
    }
}
