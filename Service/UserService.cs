using DotNetHW2;

namespace Service;

public class UserService : IUserService
{
    public static UserService userService;
    public User onlineUser { get; set; }

    public static UserService GetUserService()
    {
        if (userService == null)
        {
            userService = new UserService();
        }
        return userService;
    }

    public bool Login(string username, string password)
    {
        bool flag = false;
        foreach (User user in DataBase.GetDataBase().users)
        {
            if((user.GetName() == username)&&(user.GetPassword() == password))
            {
                flag = true;
                this.onlineUser = user;
            }
        }

        return flag;
    }

    public bool ChangePassword(string newPassword)
    {
        bool flag = false;
        foreach (User user in DataBase.GetDataBase().users)
        {
            if ((user.GetName() == onlineUser.GetName()) && (user.GetPassword() == onlineUser.GetPassword()))
            {
                user.SetPassword(newPassword);
                this.onlineUser = user;
                flag = true;
            }
        }

        return flag;
    }

    public bool ChangeName(string newName)
    {
        bool flag = false;
        foreach (User user in DataBase.GetDataBase().users)
        {
            if ((user.GetName() == onlineUser.GetName()) && (user.GetPassword() == onlineUser.GetPassword()))
            {
                user.SetName(newName);
                this.onlineUser = user;
                flag = true;
            }
        }

        return flag;
    }

    public bool ChangeAddress(string newAddress)
    {   bool flag = false;
        foreach (User user in DataBase.GetDataBase().users)
        {
            if ((user.GetName() == onlineUser.GetName()) && (user.GetPassword() == onlineUser.GetPassword()))
            {
                ((NormalUser)user).setAddress(newAddress);
                this.onlineUser = user;
                flag = true;
            }
        }

        return flag;
        
    }

    public bool SignUp(string name, string pass, string address,UserType userType)
    {
        bool flag=false;
        if (userType == UserType.Admin)
        {
            Admin newAdmin=new Admin(name,pass);
            DataBase.GetDataBase().users.Add(newAdmin);
            flag = true;
        }else if (userType == UserType.NormalUser)
        {
            NormalUser normalUser=new NormalUser(name, pass, address);
            DataBase.GetDataBase().users.Add(normalUser);
            flag = true;
        }
        return flag;
    }
}