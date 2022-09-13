public class Square : Shape
{
    private float Side { get; }

    public Square(float side)
    {
        Side = side;
    }

    public override float Area()
    {
        return Side * Side;
    }
}