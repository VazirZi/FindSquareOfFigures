class Circle : Figure
{
    public Circle(double _r)
    {
        r = _r;
    }
    public double r { get; set; }
    public override void FindSquare()
    {
        double result = (Math.Pow(r, 2)) * Math.PI;
        GetQuantity(result);
    }
}
