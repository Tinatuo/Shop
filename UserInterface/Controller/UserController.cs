using DotNetHW2;

namespace UserInterface.Controller;
using Microsoft.AspNetCore.Mvc;


[ApiController]
[Route("item-api")]
public class UserController:ControllerBase
{
    [HttpPost("login-user")]
    public ContentResult Login(string username, string password)
    {
        bool result = Service.UserService.GetUserService().Login(username, password);
        if (result)
        {
            return Content("Login successful");
        }
        else
        {
            return Content("Login failed");
        }
        
    }

    [HttpPost("sign-up-user")]
    public ContentResult Signup(string name, string pass, string address, UserType userType)
    {
        bool result=Service.UserService.GetUserService().SignUp(name, pass, address, userType);
        if (result)
        {
            return Content("Signup successful");
        }
        else
        {
            return Content("Signup failed");
        }
    }

    [HttpPut("change-address-user")]
    public ContentResult ChangeAddress(string newAddress)
    {
        bool result = Service.UserService.GetUserService().ChangeAddress(newAddress);
        if (result)
        {
            return Content("Address changed");
        }
        else
        {
            return Content("Address not changed");
        }
    }

    [HttpPut("change-password-user")]
    public ContentResult ChangePassword(string newPassword)
    {
        bool result = Service.UserService.GetUserService().ChangePassword(newPassword);
        if (result)
        {
            return Content("Password changed");
        }
        else
        {
            return Content("Password not changed");
        }
    }

    [HttpPost("change-name-user")]
    public ContentResult ChangeName(string name)
    {
        bool result = Service.UserService.GetUserService().ChangeName(name);
        if (result)
        {
            return Content("Name changed");
        }
        else
        {
            return Content("Name not changed");
        }
       
    }
}
