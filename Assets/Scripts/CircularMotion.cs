using UnityEngine;

public class CircularMotion : MonoBehaviour
{
    public float radius = 2.0f; // circle radius
    public float speed = 2.0f; // movement speed
    public float startY = 0.0f; // start Y position

    private float angle = 0.0f; // current angle in radians

    private void Start()
    {
        // position the object at the start of the circular path
        transform.position = new Vector3(
           radius * Mathf.Cos(angle),
            startY,
            radius * Mathf.Sin(angle)
        );
    }

    private void Update()
    {
        // move the object along the circular path
        angle += speed * Time.deltaTime;
        transform.position = new Vector3(
            radius * Mathf.Cos(angle),
            startY,
            radius * Mathf.Sin(angle)
        );
    }
}
