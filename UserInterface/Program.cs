using DotNetHW2;
using Service;

void First()
{
    Console.WriteLine("Welcom to shop");
    Console.WriteLine("what do you want to do?");
    Console.WriteLine("1.sign up");
    Console.WriteLine("2.log in");
    Console.WriteLine("3.change your information");
}

void SignUp()
{
    Console.WriteLine("What is your name?");
    string name = Console.ReadLine();
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
