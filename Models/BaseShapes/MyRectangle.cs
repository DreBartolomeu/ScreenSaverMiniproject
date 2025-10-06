namespace Models.BaseShapes;

using System.Drawing;
public class MyRectangle : Shape
{
    public MyRectangle(int screenWidth, int screenHeigth)
        : base(screenWidth, screenHeigth) { }

    public override void Draw(Graphics g)
    {
        using var brush = new SolidBrush(ShapeColor);
        g.FillRectangle(brush, X, Y, Width, Heigth);
        
    }
}