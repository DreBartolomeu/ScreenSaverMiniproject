using Models.BaseShapes;

public class MyEllipse : Shape
{
    public MyEllipse(int screenWidth, int screenHeigth) : base(screenWidth, screenHeigth) { }

    public override void Draw(Graphics g)
    {
        using var brush = new SolidBrush(ShapeColor);
        g.FillEllipse(brush, X, Y, Width, Heigth);
    }
}