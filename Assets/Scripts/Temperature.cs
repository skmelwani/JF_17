using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Temperature : MonoBehaviour
{
    public Text temperatureText;
    public float updatedTemperature;
    public Text val;
    public Image TemperatureBar;
    public float maxTemperature;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.LeftArrow))
        {
            updatedTemperature +=13;
            
        }
        temperatureText.text = (int)updatedTemperature + "C";
        TemperatureBar.fillAmount = updatedTemperature / maxTemperature;

        if (updatedTemperature > 200)
        {
            val.text = "Plane is \n ready to fly";
        }

    }
}
