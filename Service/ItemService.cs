using DotNetHW2;

namespace Service;


public class ItemService: IItemService
{

    public bool AddBook(int price, int numbersOfItem, string address, int numberOfPages, string publication)
    {
        bool result = false;
        Books newBook=new Books(price, address, numberOfPages, publication);
        if (DataBase.GetDataBase().items.Contains(newBook))
        {
            int index = DataBase.GetDataBase().items.IndexOf(newBook);
            DataBase.GetDataBase().items[index].SetNumberOfItem(DataBase.GetDataBase().items[index].GetNumbersOfItem()+1);
            result = true;
        }
        else
        {
            DataBase.GetDataBase().items.Add(newBook);
            newBook.SetNumberOfItem(numbersOfItem);
            result = true;
        }
        return result;
    }

    public bool AddPen(int price, int numbersOfItem, string address, string brand, string color)
    {
        bool result = false;
        Pen newPen=new Pen(price, address, brand, color);
        if (DataBase.GetDataBase().items.Contains(newPen))
        {
            int index = DataBase.GetDataBase().items.IndexOf(newPen);
            DataBase.GetDataBase().items[index].SetNumberOfItem(DataBase.GetDataBase().items[index].GetNumbersOfItem()+1);
            result = true;
        }
        else
        {
            DataBase.GetDataBase().items.Add(newPen);
            newPen.SetNumberOfItem(numbersOfItem);
            result = true;
        }
        return result;
    }

    public bool RemoveItem(Item item)
    {
        DataBase.GetDataBase().items.Remove(item);
        return true;
    }

    public bool BuyItem(Item item)
    {
        bool result = false;
        if (item.GetNumbersOfItem() > 0)
        {
            int nub = DataBase.GetDataBase().items.IndexOf(item);
            DataBase.GetDataBase().items[nub].SetNumberOfItem(item.GetNumbersOfItem()-1);
            ((NormalUser)UserService.GetUserService().onlineUser).GetItems().Add(item);
            result = true;
        }
        else
        {
            DataBase.GetDataBase().items.Remove(item);
        }

        return result;
    }
}