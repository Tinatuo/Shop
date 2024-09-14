namespace DotNetHW2;

public class pen:Item
{
    private string brand;
    private string color;

    public pen(int price, int numbersOfBooks, string address, string brand, string color) : base(price, numbersOfBooks, address)
    {
        this.brand = brand;
        this.color = color;
    }
}