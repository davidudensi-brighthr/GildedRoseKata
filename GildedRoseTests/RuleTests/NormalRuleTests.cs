using GildedRose.Rules;
using GildedRoseKata;

namespace GildedRoseTests.RuleTests;

public class NormalRuleTests
{
    [Fact]
    public void UpdateQuality_Should_ReduceQualityBy1()
    {
        var item = new Item { Name = "+5 Dexterity Vest", SellIn = 10, Quality = 20 };
        var sut = new NormalRule();
        sut.UpdateQuality(item);
        Assert.Equal(19, item.Quality);
        Assert.Equal(9, item.SellIn);
    }

    [Fact]
    public void UpdateQuality_QualityShouldNotReduce_LessZero()
    {
        var item = new Item { Name = "+5 Dexterity Vest", SellIn = 10, Quality = 5 };
        var sut = new NormalRule();

        for (int i = 0; i < 6; i++)
        {
            sut.UpdateQuality(item);
        }
        Assert.Equal(0, item.Quality);
    }

    [Fact]
    public void UpdateQuality_SellIn_ShouldReduceEachDay()
    {
        var item = new Item { Name = "+5 Dexterity Vest", SellIn = 5, Quality = 5 };
        var sut = new NormalRule();

        for (int i = 0; i < 6; i++)
        {
            sut.UpdateQuality(item);
        }
        Assert.Equal(-1, item.SellIn);
    }

    [Fact]
    public void UpdateQuality_WhenSellInIsPassed_QualityShouldReduceTwiceAsFast()
    {
        var item = new Item { Name = "+5 Dexterity Vest", SellIn = -1, Quality = 10 };
        var sut = new NormalRule();

        sut.UpdateQuality(item);
        Assert.Equal(8, item.Quality);
    }

    [Theory]
    [InlineData(10, 8)]
    [InlineData(2, 0)]
    [InlineData(0, 0)]
    public void UpdateQuality_WhenMultiplier(int quality, int expected)
    {
        var item = new Item { Name = "+5 Dexterity Vest", SellIn = 5, Quality = quality };
        var sut = new NormalRule(2);

        sut.UpdateQuality(item);
        Assert.Equal(expected, item.Quality);
    }

    [Theory]
    [InlineData(10, 6)]
    [InlineData(2, 0)]
    [InlineData(0, 0)]
    public void UpdateQuality_WhenMultiplierAndSellInPassed(int quality, int expected)
    {
        var item = new Item { Name = "+5 Dexterity Vest", SellIn = -5, Quality = quality };
        var sut = new NormalRule(2);

        sut.UpdateQuality(item);
        Assert.Equal(expected, item.Quality);
    }
}
