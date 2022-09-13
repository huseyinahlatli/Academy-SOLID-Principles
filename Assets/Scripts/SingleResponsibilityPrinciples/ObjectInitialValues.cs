using UnityEngine;

public class ObjectInitialValues
{
    private ObjectProperties _objectProperties;
    public Color GetColor()
    {
        var randomColor = new Color
        (
            Random.Range(0, 1f),
            Random.Range(0, 1f),
            Random.Range(0, 1f)
        );
        return randomColor;
    }

    public Vector3 GetPosition()
    {
        const float maxPosition = 2f;
        const float maxHeight = 8f;

        var randomPosition = new Vector3
        (
            Random.Range(-maxPosition, maxPosition),
            maxHeight,
            Random.Range(-maxPosition, maxPosition)
        );
        return randomPosition;
    }
}

