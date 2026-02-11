public abstract class Shape
{
    private string _color;

    public Shape(string color)
    {
        _color = color;
    }

    // Getter and setter for color
    public string GetColor()
    {
        return _color;
    }
    public void SetColor(string color)
    {
        _color = color;
    }

    // Abstract method for calculating area
    public abstract double GetArea();
}