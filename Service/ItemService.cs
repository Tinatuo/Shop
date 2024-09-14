﻿using DotNetHW2;

namespace Service;

public class ItemService : IItemService
{
    public static ItemService itemService;

    public static ItemService GetItemService()
    {
        if (itemService == null)
        {
            itemService = new ItemService();
        }
        return itemService;
    }

    public void Login(string username, string password)
    {
      
    }

    public void ChangePassword(string newPassword)
    {
        throw new NotImplementedException();
    }

    public void ChangeName(string newName)
    {
        throw new NotImplementedException();
    }

    public void ChangeAddress(string newAddress)
    {
        throw new NotImplementedException();
    }

    public void SignUp(string name, string pass, string address,UserType userType)
    {
        if (userType == UserType.Admin)
        {
            Admin newAdmin=new Admin(name,pass);
            DataBase.GetDataBase().users.Add(newAdmin);
        }else if (userType == UserType.NormalUser)
        {
            NormalUser normalUser=new NormalUser(name, pass, address);
            DataBase.GetDataBase().users.Add(normalUser);
        }
    }
}