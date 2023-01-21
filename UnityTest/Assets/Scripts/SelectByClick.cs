using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Renderer))]

public class SelectByClick : MonoBehaviour
{
    //OnMouseDown Event. 
    //Goals: 1. Activate current object, Set all other object to inactive. 
    //2. Display name of the gameobject. 
    public GameObject descriptionCanvas;
    public GameObject visualEffect;
    private bool active;
    Color colorActivated;

    void Start()
    {
        colorActivated = gameObject.GetComponent<Renderer>().material.color;
        Deactivate();
    }

    public void Activate()
    {
        ObjectController.Instance.DeactivateAllChildren();
        active = true;
        gameObject.GetComponent<Renderer>().material.color = new Color(colorActivated.r, colorActivated.g, colorActivated.b, 1f);
        descriptionCanvas.SetActive(true);
        visualEffect.SetActive(true);
    }

    public void Deactivate()
    {
        gameObject.GetComponent<Renderer>().material.color = new Color(colorActivated.r, colorActivated.g, colorActivated.b, 0.5f);
        descriptionCanvas.SetActive(false);
        visualEffect.SetActive(false);
        active = false;
    }

    private void OnMouseDown()
    {
        Debug.Log("clicked " + gameObject.name);
        if (active == false)
        {
            Activate();
        }

    }


}
