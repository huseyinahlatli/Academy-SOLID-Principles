using UnityEngine;

public class CalculateManager : MonoBehaviour
{
    #region Singleton : CalculateManager
    public static CalculateManager Instance;
    
    private void Awake()
    {
        if (Instance == null)
            Instance = this;
    }
    #endregion

    public float RectangleArea(float width, float height)
    {
        Rectangle rectangle = new Rectangle(width, height);
        var rectangleArea = rectangle.Area();
        return rectangleArea;
    }

    public float SquareArea(float side)
    {
        Square square = new Square(side);
        var squareArea = square.Area();
        return squareArea;
    }

    public float CircleArea(float radius)
    {
        Circle circle = new Circle(radius);
        var circleArea = circle.Area();
        return circleArea;
    }
}
