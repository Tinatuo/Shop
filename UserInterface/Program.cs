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
        Console.WriteLine("what do you want to change?");
        string input = Console.ReadLine();
        ChangeInfo(input);
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
        UserService.GetUserService().SignUp(name,pass,null,UserType.Admin);
        Console.WriteLine("Welcome Admin");
    }
    else if (type == "NormalUser")
    {
        Console.WriteLine("please write your address");
        string address = Console.ReadLine();
       UserService.GetUserService().SignUp(name,pass,address,UserType.NormalUser);
       Console.WriteLine("Welcome NormalUser");
    }
}

void LogIn()
{
    Console.WriteLine("What is your name?");
    string name = Console.ReadLine();
    Console.WriteLine("what is your password?");
    string pass = Console.ReadLine();
    if (UserService.GetUserService().Login(name, pass))
    {
        Console.WriteLine("you are logged in");
    }

    if (UserService.GetUserService().onlineUser is Admin)
    {
        
    }else if (UserService.GetUserService().onlineUser is NormalUser)
    {
        
    }
}

void AdminMenu()
{
    Console.WriteLine("1.addBook     2.addPen    3.remove a item"  );
    string input = Console.ReadLine();
    if (input.Equals("1"))
    {
        Console.WriteLine("Write price of book:");
        int price = int.Parse(Console.ReadLine());
        Console.WriteLine("Write address:");
        string address = Console.ReadLine();
        Console.WriteLine("Write number of items(if it is new):");
        int numberOfItems = int.Parse(Console.ReadLine());
        Console.WriteLine("Write publication of book:");
        string publication = Console.ReadLine();
        Console.WriteLine("Write number of pages of book:");
        int numberOfPages = int.Parse(Console.ReadLine());
        ItemService.itemService.AddBook(price, numberOfItems, address,numberOfPages, publication);
    }else if (input.Equals("2"))
    {
        Console.WriteLine("Write price of book:");
        int price = int.Parse(Console.ReadLine());
        Console.WriteLine("Write address:");
        string address = Console.ReadLine();
        Console.WriteLine("Write number of items(if it is new):");
        int numberOfItems = int.Parse(Console.ReadLine());
        Console.WriteLine("write brand of this pen:");
        string brand = Console.ReadLine();
        Console.WriteLine("write color of this pen:");
        string color = Console.ReadLine();
        ItemService.GetItemService().AddPen(price,numberOfItems, address, brand, color);
    }else if (input.Equals("3"))
    {
        foreach (Item item in DataBase.GetDataBase().items)
        {
            Console.WriteLine((DataBase.GetDataBase().items.IndexOf(item)+1)+"."+item.GetType().Name);
        }
        Console.WriteLine("which item would you like to remove?");
        int remove = int.Parse(Console.ReadLine())-1;
        ItemService.GetItemService().RemoveItem(DataBase.GetDataBase().items[remove]);
    }
    
}
void ChangeInfo(string input)
{
    
    Console.WriteLine("what do you want to change?");
    Console.WriteLine("1.Name   2.password  3.address ");
    if (Console.ReadLine().Equals("1"))
    {
        UserService.GetUserService().ChangeName(input);
        Console.WriteLine("Done");
        
    }else if (input.Equals("2"))
    {
        UserService.GetUserService().ChangePassword(input);
        Console.WriteLine("Done");

    }else if (input.Equals("3"))
    {
        UserService.GetUserService().ChangeAddress(input);
        Console.WriteLine("Done");

    }
}
