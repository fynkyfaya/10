FilledRectangle filledRectangle = new FilledRectangle(
    int.Parse(Console.ReadLine()),
    int.Parse(Console.ReadLine()),
    int.Parse(Console.ReadLine()),
    int.Parse(Console.ReadLine()),
    "black",
    "Hello world!"
);

Console.WriteLine(filledRectangle.isSquare());
Console.WriteLine(filledRectangle.GetPerimeter());
Console.WriteLine(filledRectangle.GetDiagonal());


class FilledRectangle : Rectangle
{
    public string color;
    public string text;

    public FilledRectangle(int x1, int y1, int x2, int y2, string color, string text) : base(x1, y1, x2, y2)
    {
        this.color = color;
        this.text = text;
    }

    public int GetPerimeter()
    {
        return (width + height) * 2;
    }

    public double GetDiagonal()
    {
        return Math.Sqrt(Math.Pow(width, 2) + Math.Pow(height, 2));
    }
}

class Rectangle
{
    public int x1;
    public int x2;
    public int y1;
    public int y2;

    protected int width;
    protected int height;

    public Rectangle(int x1, int y1, int x2, int y2)
    {
        this.x1 = x1;
        this.x2 = x2;
        this.y1 = y1;
        this.y2 = y2;

        width = x2 - x1;
        height = y2 - y1;
    }

    public bool isSquare()
    {
        return width == height;
    }
}