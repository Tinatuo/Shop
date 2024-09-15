using System.Collections;

namespace DotNetHW2;

public class NormalUser: User
{
    private string _address;
    private IList<Item> items;

    public IList<Item> GetItems()
    {
        return items;
    }

    public void SetItems(IList<Item> items)
    {
        this.items = items;
    }

     public string getAddress()
     {
         return _address;
     }

     public void setAddress(string address)
     {
         _address = address;
     }
    public NormalUser(string name, string password, string address) : base(name, password)
    {
        this._address = address;
        items = new List<Item>();
    }
}