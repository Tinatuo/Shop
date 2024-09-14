namespace DotNetHW2;

public class User
{
   private string name{get;set;}
   private string password{get;set;}
   public string GetName()  
   {
       return this.name;
   }
   

   public string GetPassword()
   {
       return password;
   }

    public User(string name, string password)
    {
        this.name = name;
        this.password = password;
    }
}