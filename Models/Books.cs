namespace DotNetHW2;

public class Books:Item
{
   private int numberOfPages;
    private string publication;
    public Books(int price, string address,int numberOfPages,string publication) : base(price, address)
    {
        this.numberOfPages = numberOfPages;
        this.publication = publication;
    }
}