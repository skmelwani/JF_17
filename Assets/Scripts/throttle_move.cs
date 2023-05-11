using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class throttle_move : MonoBehaviour {


    public float rotationSpeed = 10f;
    public float minRotation = 0f;
    public float maxRotation = 30f;
    private float direction = 1f;

    public AudioClip rotationSound;
    private AudioSource audioSource;
    //public AudioSource rotationSound;

    void Start () {
        audioSource = GetComponent<AudioSource>();
    }

    void Update () {

        // Rotate the object around the z-axis on keyboard input
        if (Input.GetKeyDown(KeyCode.LeftArrow)) {
            transform.Rotate(Vector3.forward * rotationSpeed * Time.deltaTime);
            if (Input.GetKeyDown(KeyCode.LeftArrow)) {
            audioSource.PlayOneShot(rotationSound);

            //audioSource.Play();
        }
            

        } else if (Input.GetKeyDown(KeyCode.RightArrow)) {
            transform.Rotate(Vector3.back * rotationSpeed * Time.deltaTime);
        }

        // Clamp the rotation within the specified range
        float currentRotation = transform.eulerAngles.z;
        if (currentRotation > maxRotation) {
            currentRotation = maxRotation;
            transform.eulerAngles = new Vector3(transform.eulerAngles.x, transform.eulerAngles.y, currentRotation);
        } else if (currentRotation < minRotation) {
            currentRotation = minRotation;
            //transform.eulerAngles = new Vector3(transform.eulerAngles.x, transform.eulerAngles.y, currentRotation);
        }
    }
}
