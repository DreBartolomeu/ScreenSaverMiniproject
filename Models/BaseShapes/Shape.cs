namespace Models.BaseShapes;

public abstract class Shape
{
    protected int X { get; private set; }
    protected int Y { get; private set; }
    protected int SpeedX { get; private set; }
    protected int SpeedY { get; private set; }
    protected int Width;
    protected int Heigth;
    protected Color ShapeColor;
    protected Random Rand = new Random();

    protected Shape(int screenWidth, int screenHeigth)
    {
        Width = Rand.Next(10, 50);
        Heigth = Rand.Next(10, 50);
        X = Rand.Next(0, screenWidth - Width);
        Y = Rand.Next(0, screenHeigth - Heigth);
        SpeedX = Rand.Next(-5, 5);
        SpeedY = Rand.Next(-5, 5);
        ShapeColor = ColorGenerate();

        if (SpeedX == 0)
            SpeedX--;

        if (SpeedY == 0)
            SpeedY++;
    }

    public void Move(int screenWidth, int screenHeigth)
    {
        X += SpeedX;
        Y += SpeedY;

        if (X < 0 || X + Width > screenWidth)
        {
            SpeedX = -SpeedX;
            ShapeColor = ColorGenerate();  
        }
        if (Y < 0 || Y + Heigth > screenHeigth)
        {
            SpeedY = -SpeedY;
            ShapeColor = ColorGenerate();  
        } 
    }

    private Color ColorGenerate()
    {
        int red = Rand.Next(0, 255);
        int green = Rand.Next(0, 255);
        int blue = Rand.Next(0, 255);

        return Color.FromArgb(red, green, blue);
    }
    public abstract void Draw(Graphics g);
}