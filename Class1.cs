namespace cs222_w3;

public class Shape
{
    public double Height { get; set; }
    public double Width { get; set; }

    public virtual double Area
    {
        get { return 0; }
    }
}
public class Rectangle : Shape
{
    public Rectangle(double height, double width)
    {
        Height = height;
        Width = width;
    }

    public override double Area => Height * Width;
}
public class Square : Shape
{
    public Square(double size)
    {
        Height = size;
        Width = size;
    }

    public override double Area => Height * Width;
}
public class Circle : Shape
{
    public Circle(double radius)
    {
        Height = radius * 2;
        Width = radius * 2;
    }

    public override double Area => Math.PI * Math.Pow(Height / 2, 2);
}
