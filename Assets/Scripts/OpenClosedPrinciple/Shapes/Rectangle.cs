public class Rectangle : Shape
{
    private float Width { get; }
    private float Height { get; }

    public Rectangle(float width, float height)
    {
        Width = width;
        Height = height;
    }

    public override float Area()
    {
        return Width * Height;
    }
}
