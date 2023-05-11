using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class changeColor : MonoBehaviour
{
    public Button button;
    public Color newColor;
    public GameObject[] objects;

    void Start()
    {
        button.onClick.AddListener(ChangeColors);
    }

    void ChangeColors()
    {
        foreach (GameObject obj in objects)
        {
            obj.GetComponent<Renderer>().material.color = newColor;
        }
    }
}

