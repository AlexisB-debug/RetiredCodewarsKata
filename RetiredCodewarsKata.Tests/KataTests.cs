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

    [Theory]
    [InlineData(new int[] { }, new int[] { })]
    [InlineData(new int[] { 2, 4, 6 }, new int[] { })]
    [InlineData(new int[] { 1, 3, 5 }, new int[] { 1, 3, 5 })]
    [InlineData(new int[] { 1, 2, 3, 4, 5, 6 }, new int[] { 1, 3, 5 })]
    public void AreArrowFunctionsOddTest(int[] values, int[] expected)
    {
        Kata kata = new Kata();

        List<int> actual = kata.AreArrowFunctionsOdd(values.ToList());

        Assert.Equal(expected.ToList(), actual);
    }
}
