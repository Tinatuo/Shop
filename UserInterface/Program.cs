using DotNetHW2;
using Service;
First();
void First()
{
    Console.WriteLine("Welcom to shop");
    Console.WriteLine("what do you want to do?");
    Console.WriteLine("1.sign up");
    Console.WriteLine("2.log in");
    Console.WriteLine("3.change your information");
    string userInput = Console.ReadLine();
    if (userInput.Equals("1"))
    {
        SignUp();
    }else if (userInput.Equals("2"))
    {
        LogIn();
    }else if (userInput.Equals("3"))
    {
        
    }
    {
        
    }
}

void SignUp()
{
    Console.WriteLine("What is your name?");
    string name = Console.ReadLine();
    Console.WriteLine("What is your password?");
    string pass = Console.ReadLine();
    Console.WriteLine("1.Admin    2.NormalUser");
    string type = Console.ReadLine();
    if (type == "Admin")
    {
        ItemService.GetItemService().SignUp(name,pass,null,UserType.Admin);
        Console.WriteLine("Welcome Admin");
    }
    else if (type == "NormalUser")
    {
        Console.WriteLine("please write your address");
        string address = Console.ReadLine();
       ItemService.GetItemService().SignUp(name,pass,address,UserType.NormalUser);
       Console.WriteLine("Welcome NormalUser");
    }
}

void LogIn()
{
    Console.WriteLine("What is your name?");
    string name = Console.ReadLine();
    Console.WriteLine("what is your password?");
    string pass = Console.ReadLine();
    if (ItemService.GetItemService().Login(name, pass))
    {
        Console.WriteLine("you are logged in");
    }
}

void ChangeInfo(string input)
{
    Console.WriteLine("what do you want to change?");
    Console.WriteLine("1.Name   2.password  3.address ");
    if (Console.ReadLine().Equals("1"))
    {
        ItemService.GetItemService().ChangeName(input);
    }else if (input.Equals("2"))
    {
        ItemService.GetItemService().ChangePassword(input);
    }else if (input.Equals("3"))
    {
        ItemService.GetItemService().ChangeAddress(input);
    }
}
