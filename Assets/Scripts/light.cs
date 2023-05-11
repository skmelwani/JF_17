using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class light : MonoBehaviour
{
   //public KeyCode pressDown;

    public GameObject light1;
    public bool val = false;
    // Start is called before the first frame update
    void Start()
    {
        light1.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {

        light1.SetActive(false);

        if (Input.GetMouseButtonDown(0))
        {
            if (val == false)
            {
                val = true;
            }
            else if (val == true)
            {
                val = true;
            }


        }

        if (val == true)
        {
            light1.SetActive(true);
        }


        else if (val == false)
        {
            light1.SetActive(false);
        }
       
            


    }
    
}