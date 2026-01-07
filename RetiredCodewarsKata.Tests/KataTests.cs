namespace RetiredCodewarsKata.Tests;

public class KataTests
{
    [Theory]
    [InlineData(new string[] { "stone", "stone", "gold", "stone", "stone" }, true)]
    [InlineData(new string[] { "stone", "stone", "stone", "stone", "stone" }, false)]
    [InlineData(new string[] { "gold", "gold", "gold", "gold", "gold" }, true)]
    public void ManInTheWestTest(string[] bucket, bool expected)
    {
        Kata kata = new Kata();
        
        bool actual = kata.ManInTheWest(bucket);
        
        Assert.Equal(expected, actual);
    }
    
    [Theory]
    [InlineData(new string[] { "stone", "stone", "gold", "stone", "stone" }, "I will bye a teeth")]
    [InlineData(new string[] { "stone", "stone", "stone", "stone", "stone" }, "Not today")]
    [InlineData(new string[] { "gold", "gold", "gold", "gold", "gold" }, "I will bye a teeth")]
    public void ManInTheWestAlternativeTest(string[] bucket, string expected)
    {
        Kata kata = new Kata();
        
        string actual = kata.ManInTheWestAlternative(bucket);
        
        Assert.Equal(expected, actual);
    }
}