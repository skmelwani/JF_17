using UnityEngine;

public class CameraController : MonoBehaviour
{
    public Transform rotatePoint;
    public float rotationSpeed = 5f;

    private void Update()
    {
        if (Input.GetKey(KeyCode.RightArrow))
        {
            transform.RotateAround(rotatePoint.position, Vector3.up, rotationSpeed * Time.deltaTime);
        }
        else if (Input.GetKey(KeyCode.LeftArrow))
        {
            transform.RotateAround(rotatePoint.position, Vector3.up, -rotationSpeed * Time.deltaTime);
        }
    }
}
