using Models.BaseShapes;

public class MyCircle : MyEllipse
{
    public MyCircle(int screenWidth, int screenHeigth) : base(screenWidth, screenHeigth)
    {
        Width = Heigth;
    }

 
}