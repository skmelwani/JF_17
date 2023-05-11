using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;
public class Dropdown : MonoBehaviour
{   
    public Text text1;
    public Text text2;
    public Text text3;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void HandleInputData(int val)
    {
        if (val == 0)
        {
            text1.text = "Left MFD \n \n displays various information related to the aircraft's systems and mission status: \n \t 1. Radar Information \n \t 2. Navigation Data \n \t 3. Weapon, sensor information \n \t 4. System Status \n \t 5. Mission Status";
            text2.text = "Middle MFD \n \n displays navigation and tactical mission data: \n \t 1. Selected weapon information \n \t 2. Speed information \n \t 3. Mission selections";
            text3.text = "Right MFD \n \n displays information related to aircrafts flight controls and navigations: \n \t 1. Different Radar Modes \n \t 2. Weapon Status \n \t 3. Navigation Maps \n \t 4. Terrain traffic \n \t 5. loaded flight plans";

        }
        else if (val == 1)
        {
            text1.text = "The UFCP allows the pilot to enter data and commands for a variety of functions, such as navigation, weapons selection, and sensor control.";
            text2.text = "KNOBS: \n HUD CONT knob Middle position; HUD BRT knob Middle position; Rocker Switch Middle position; BAK BRT Knob OFF; UFCP BRT Knob Middle position";
            text3.text = "KEYPAD: \n Changing longitude and latitude values for navigation purposes";
        }
        else if (val == 2)
        {
            text1.text = "The HUD displays key flight and mission information directly in the pilot's line of sight, allowing them to maintain situational awareness and focus on the mission.";
            text2.text = "The HUD provides visual cues and alerts related to the aircraft's systems and mission status. For example, the HUD can display warning symbols and colors to alert the pilot to potential threats such as incoming missiles or terrain obstacles.";
            text3.text = "\t 1. Navigation tadpole \n \t 2. Expected Heading \n \t 3. Expected Altitude \n \t 4. ILS guidance \n \t 5. Waypoint and distance \n \t 6. Approach Mode";
        }

        else if (val == 3)
        {
            text1.text = "The Engine is started upon 2 conditions: Power supply, fuel supply, and throttle pull.";
            text2.text = "The temperature of the plane rises and engine sounds start as soon as the Engine starts.";
            text3.text = "\t 1. Navigation tadpole \n \t 2. Expected Heading \n \t 3. Expected Altitude \n \t 4. ILS guidance \n \t 5. Waypoint and distance \n \t 6. Approach Mode";
        }

        else if (val == 4)
        {
            text1.text = "The Electric panle controlls Battery ON or OFF";
            text2.text = "Controlls the Alternating current/direct current generators ONN OR OFF";
            text3.text = "It also controls the HUD symbology and brightness";
        }

        else if (val == 5)
        {
            text1.text = "Warning panel are the red lights that indicates any emgerncy that occusrs in the flight or any malfunctioning of the important components in the aircraft.";
            text2.text = "Advisory panles are green signals that displays cockpit information to the pilot and gives advisor on controls of the systems";
            text3.text = "";
        }

        else if (val == 6)
        {
            text1.text = "Flight controls includes components of the aircraft that control the aircraft movements during flights. These include the ailerons and flaps (on wings) and tail.";
            text2.text = "The wings are controlled by the control stick within the cockpit, while the tail moves by the rudder pedals.";
            text3.text = "Flight controls are mainly used to create roll/yaw/pitch movements for directing the aircraft.";
        }

    }
}

