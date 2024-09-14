namespace DotNetHW2;

public class Item
{
    private int price{get;set;}
    private int numbersOfBooks{get;set;}
    private string address{get;set;}

    public Item(int price, int numbersOfBooks, string address)
    {
        this.price = price;
        this.numbersOfBooks = numbersOfBooks;
        this.address = address;
    }
}