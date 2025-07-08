using GildedRose.Rules;
using GildedRoseKata;

namespace GildedRoseTests.RuleTests;

public class ConjuredRuleTests
{
    [Fact]
    public void UpdateQuality_Should_ReduceQualityBy2()
    {
        var item = new Item { Name = "+5 Dexterity Vest", SellIn = 10, Quality = 20 };
        var sut = new ConjuredRule();
        sut.UpdateQuality(item);
        Assert.Equal(18, item.Quality);
        Assert.Equal(9, item.SellIn);
    }

    [Fact]
    public void UpdateQuality_QualityShouldNotReduce_LessZero()
    {
        var item = new Item { Name = "+5 Dexterity Vest", SellIn = 10, Quality = 5 };
        var sut = new ConjuredRule();

        for (int i = 0; i < 4; i++)
        {
            sut.UpdateQuality(item);
        }
        Assert.Equal(0, item.Quality);
    }

    [Fact]
    public void UpdateQuality_SellIn_ShouldReduceEachDay()
    {
        var item = new Item { Name = "+5 Dexterity Vest", SellIn = 5, Quality = 5 };
        var sut = new ConjuredRule();

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
        var sut = new ConjuredRule();

        sut.UpdateQuality(item);
        Assert.Equal(6, item.Quality);
    }
}
    
