using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Switch_Cam : MonoBehaviour
{
    // Update is called once per frame
    public Camera camera1;
    public Camera camera2;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    
    public void Update()
    {
        if (Input.GetKeyDown(KeyCode.C))
        {
            //Swap enabled state to opposite one provided that only is on at a time
            camera1.enabled = !camera1.enabled;
            camera2.enabled = !camera2.enabled;
        }
    }
}
