using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectController : MonoBehaviour
{
    public static ObjectController Instance;

    void Awake()
    {
        Instance = this;
    }

    public void DeactivateAllChildren() //set every child object to the deactivated state. 
    {
        foreach (var item in GetComponentsInChildren<SelectByClick>())
        {
            item.Deactivate();
        }

    }
}
