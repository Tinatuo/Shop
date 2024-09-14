using System.Collections;

namespace DotNetHW2;

public class NormalUser: User
{
     private string _address { get; set; }
     private IList<Item> items{ get; set; }
    public NormalUser(string name, string password, string address) : base(name, password)
    {
        this._address = address;
        items = new List<Item>();
    }
}