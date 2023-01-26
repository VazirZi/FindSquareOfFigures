class  Square : Figure
{
    public Square(double _length, double _width)
    {
        length = _length;
        width = _width;
    }
    public double length { get; set; }
    public double width { get; set; }
    public override void FindSquare()
    {
        double result = length * width;
        GetQuantity(result);
    }
}
