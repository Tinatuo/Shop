using DotNetHW2;

namespace Service;

public interface IItemService
{
    public bool AddBook(int price, int numbersOfItem, string address,int numberOfPages,string publication);
    public bool AddPen(int price, int numbersOfItem, string address, string brand, string color);
    public bool RemoveItem(Item item);
    public bool BuyItem(Item item);
}