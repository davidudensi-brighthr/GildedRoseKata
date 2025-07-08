using GildedRoseKata;

namespace GildedRose.Rules;

public class ConjuredRule : IRule
{
    public void UpdateQuality(Item item)
    {
        if (item.SellIn < 0)
        {
            item.Quality = Math.Max(0, item.Quality - 4);
        }
        else if (item.Quality > 0)
        {
            item.Quality = Math.Max(0, item.Quality - 2);
        }
        item.SellIn = item.SellIn - 1;
    }
}
