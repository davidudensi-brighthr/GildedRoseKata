using GildedRose.Rules;
using GildedRoseKata;

namespace GildedRoseTests;

public class GildedRoseTest
{
    [Fact]
    public void Foo()
    {
        Dictionary<Item, IRule> items = new Dictionary<Item, IRule>
        {
            { new Item { Name = "foo", SellIn = 0, Quality = 0 }, new NormalRule() }
        };

        GildedRoseService app = new(items);
        app.UpdateQuality();
        Assert.Equal("foo", items.Keys.First().Name); 
    }
}
