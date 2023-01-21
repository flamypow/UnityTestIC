using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class FindSceneManager : MonoBehaviour
{
    public int buttonIndex = 0; //the scene number this button is going to

    public Button currentButton;

    void Start()
    {
        currentButton.onClick.AddListener(FindManagerLoadScene);
    }

    void FindManagerLoadScene()
    {
        Debug.Log("clicked");
        SceneController.Instance.LoadScene(buttonIndex);
    }
}
