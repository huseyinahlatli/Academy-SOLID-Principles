public class AreaCalculator
{
    public float Area(Shape[] shapes)
    {
        float area = 0;
        foreach (var shape in shapes)
        {
            area += shape.Area();
        }
        return area;
    }
}