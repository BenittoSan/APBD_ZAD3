namespace TestUnit;
using LegacyApp;





public class UserServiceTest
{
    [Test]
    public void AddUser_Should_Return_False_When_Missing_FirstName()
    {
        //Arrange
        var service = new UserService();

        //Act
        var result = service.AddUser(null, null, "kowalski@wp.pl", new DateTime(1980, 1, 1), 1);
        
        //Assert
        Assert.False(result);
    }

    [Test]
    public void AddUser_Should_Throw_Exception_When_User_Does_Not_Exists()
    {
        //Arrange
        var service = new UserService();
        
        //Act and Assert
        Assert.Throws<ArgumentException>(() =>
        {
            _ = service.AddUser("asd", "adwa", "nowak@wp.pl", new DateTime(1300, 1, 1), 1);
        });
        
        //Assert.Throws()
    }
    
    
}