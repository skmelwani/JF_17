using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

using TMPro;
using UnityEngine.EventSystems;

public class Input_number : MonoBehaviour
{
    public string textToAdd = "";
    public Button button_lat;
    public Button button_long;

    public TMP_InputField lat_inputField;
    public TMP_InputField long_inputField;
    void Start()
    {
        button_lat.onClick.AddListener(button_latClicked);
        button_long.onClick.AddListener(button_longClicked);
    }
    void button_latClicked()
    {
        lat_inputField.text = "";
        lat_inputField.text += textToAdd;
        

    }

    void button_longClicked()
    {
        long_inputField.text = "";
        long_inputField.text += textToAdd;
    }

    public void AddText(string text1)
    {
        textToAdd = text1;
    }
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            GameObject clickedObject = EventSystem.current.currentSelectedGameObject;
            if (clickedObject == button_lat.gameObject)
            {
                button_latClicked();
            }
            else if (clickedObject == button_long.gameObject)
            {
                button_longClicked();
            }
        }
    }

}