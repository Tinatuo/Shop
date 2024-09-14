namespace DotNetHW2;

public class DataBase
{
    public IList<User> users;
    public IList<Item> items;
    public static DataBase db;

    public DataBase()
    {
        users = new List<User>();
        items = new List<Item>();
    }

    public static DataBase GetDataBase()
    {
        if (db == null)
        {
            db = new DataBase();
        }
        return db;
    }
}