using DotNetHW2;

namespace Service;

public interface IItemService
{
    public bool Login(string username, string password);
    public void ChangePassword(string newPassword);
    public void ChangeName(string newName);
    public void ChangeAddress(string newAddress);
    public void SignUp(string name, string pass, string address,UserType userType);
    
}