using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

[RequireComponent(typeof(TMPro.TextMeshProUGUI))]

public class ChangeText : MonoBehaviour
{

    private TextMeshProUGUI currentText;
    public GameObject parentObject; //for versatility
    // Start is called before the first frame update
    void Start()
    {
        currentText = GetComponent<TMPro.TextMeshProUGUI>();
        currentText.text = (parentObject.name);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
