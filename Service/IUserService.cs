using DotNetHW2;

namespace Service;

public interface IUserService
{
    public bool Login(string username, string password);
    public bool ChangePassword(string newPassword);
    public bool ChangeName(string newName);
    public bool ChangeAddress(string newAddress);
    public void SignUp(string name, string pass, string address,UserType userType);
    
}