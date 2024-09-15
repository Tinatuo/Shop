namespace DotNetHW2;

public class Item
{
    private int price;
    private int numbersOfItem;
    private string address;

    public int GetPrice()
    {
        return price;
    }

    public void SetPrice(int price)
    {
        this.price = price;
    }
    public int GetNumbersOfItem()
    {
        return numbersOfItem;
    }

    public void SetNumberOfItem(int numbersOfItem)
    {
        this.numbersOfItem = numbersOfItem;
    }
    public string GetAddress ()
    {
        return address;
    }

    public void SetAddress(string address)
    {
        this.address = address;
    }
    public Item(int price, string address)
    {
        this.price = price;
        this.address = address;
    }
}