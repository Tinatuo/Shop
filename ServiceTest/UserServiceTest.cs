using DotNetHW2;
using Service;

namespace ServiceTest;

public class UserServiceTest
{
    private UserService _sut;

    public UserServiceTest()
    {
        _sut = new UserService();
    }

    [Fact]
    public void SignupTest()
    {
        var actual = _sut.SignUp("Tina", "123", "nazar", UserType.NormalUser);
        var expected = true;
        Assert.Equal(expected, actual);
    }

    [Fact]
    public void LoginTest()
    {
        _sut.SignUp("Tina", "123", "nazar", UserType.NormalUser);
        var actual = _sut.Login("Tina", "123");
        var expected = true;
        Assert.Equal(expected, actual);
    }

    [Fact]
    public void ChangePasswordTest()
    {
        _sut.SignUp("Tina", "123", "nazar", UserType.NormalUser);
        _sut.Login("Tina", "123");
        var actual = _sut.ChangePassword("234");
        var expected = true;
        Assert.Equal(expected, actual);
    }
    [Fact]
    public void ChangeNameTest()
    {
        _sut.SignUp("Tina", "123", "nazar", UserType.NormalUser);
        _sut.Login("Tina", "123");
        var actual = _sut.ChangeName("Ardalan");
        var expected = true;
        Assert.Equal(expected, actual);
    }
    [Fact]
    public void ChangeAddressTest()
    {
        _sut.SignUp("Tina", "123", "nazar", UserType.NormalUser);
        _sut.Login("Tina", "123");
        var actual = _sut.ChangeAddress("yoyo");
        var expected = true;
        Assert.Equal(expected, actual);
    }
}