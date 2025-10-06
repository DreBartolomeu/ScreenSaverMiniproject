namespace Models.BaseShapes;

public class MySquare : MyRectangle
{
    public MySquare(int screenWidth, int screenHeigth) : base(screenWidth, screenHeigth)
    {
        Width = Heigth;
    }
}