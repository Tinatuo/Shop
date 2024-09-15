namespace DotNetHW2;

public class Pen:Item
{
    private string brand;
    private string color;

    public Pen(int price, string address, string brand, string color) : base(price, address)
    {
        this.brand = brand;
        this.color = color;
    }
}