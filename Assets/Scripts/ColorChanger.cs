using UnityEngine;

public class ColorChanger : MonoBehaviour
{
    private float timeSinceLastColorChange = 0.0f;
    public float minColorChangeInterval = 1.0f;
    public float maxColorChangeInterval = 5.0f;
    public Color[] colors;

    void Update()
    {
        timeSinceLastColorChange += Time.deltaTime;

        if (timeSinceLastColorChange > GetRandomColorChangeInterval())
        {
            timeSinceLastColorChange = 0.0f;
            SetRandomColor();
        }
    }

    void SetRandomColor()
    {
        Color newColor = colors[Random.Range(0, colors.Length)];
        GetComponent<Renderer>().material.color = newColor;
    }

    float GetRandomColorChangeInterval()
    {
        return Random.Range(minColorChangeInterval, maxColorChangeInterval);
    }
}
