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

   public void SetName(string name)
   {
       this.name = name;
   }

   public void SetPassword(string password)
   {
       this.password = password;
   }

    public User(string name, string password)
    {
        this.name = name;
        this.password = password;
    }
}