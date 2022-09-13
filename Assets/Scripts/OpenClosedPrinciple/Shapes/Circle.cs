using UnityEngine;

public class Circle : Shape
{
    private float Radius { get; }

    public Circle(float radius)
    {
        Radius = radius;
    }

    public override float Area()
    {
        return Radius * Radius * Mathf.PI;
    }
}