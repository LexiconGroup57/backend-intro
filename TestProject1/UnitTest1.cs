using Backend_intro;

namespace TestProject1;

public class UnitTest1
{
    [Fact]
    public void Test1()
    {
        //Arrange
        int yearBorn = 2002;
        int expected = 23;
        
        //Act
        int actual = Backend_intro.Person.GetAge(yearBorn);
        //Assert
        
        Assert.Equal(expected, actual);
    }

    [Theory]
    [InlineData(2023, 2)]
    [InlineData(1999, 26)]
    [InlineData(1799, 226)]
    public void PersonGetAgeTest(int yearBorn, int expected)
    {
        //Act
        int actual = Backend_intro.Person.GetAge(yearBorn);
        //Assert
        
        Assert.Equal(expected, actual);
    }

    [Fact]
    public void PresentationTest()
    {
        //Arrange
        Presentation present = new Presentation();
        int x = 23;
        bool expected = true;
        
        //Act
        bool actual = present.PureEvaluation(x);
        
        //Assert
        Assert.Equal(expected, actual);
        
    }
    
    
}