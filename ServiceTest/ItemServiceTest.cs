using DotNetHW2;
using Service;
using Xunit.Sdk;

namespace ServiceTest;

public class ItemServiceTest
{
    private ItemService _sut;

    public ItemServiceTest()
    {
        _sut = new ItemService();
    }

    [Fact]
    public void AddBookTest()
    {
        var actual = _sut.AddBook(1000, 3, "aaa", 50, "fff");
        var expected = true;
        Assert.Equal(expected, actual);
    }

    [Fact]
    public void AddPageTest()
    {
        var actual = _sut.AddPen(1000, 3, "aaa", "ggg", "red");
        var expected = true;
        Assert.Equal(expected, actual);
    }

    [Fact]
    public void BuyItemTest()
    {
        UserService.GetUserService().onlineUser = new NormalUser("Tina", "123", "aaa");
        _sut.AddBook(3000, 3, "aba", 50, "fff");
        var actual = _sut.BuyItem(DataBase.GetDataBase().items[0]);
        var expected = true;
        Assert.Equal(expected, actual);
    }

    [Fact]
    public void RemoveItemTest()
    {
        _sut.AddBook(1000, 3, "aaa", 50, "fff");
        var actual = _sut.RemoveItem(DataBase.GetDataBase().items[0]);
        var expected = true;
        Assert.Equal(expected, actual);
    }
}