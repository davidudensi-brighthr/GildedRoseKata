using GildedRoseKata;

namespace GildedRose.Rules;

public class AgedBrieRule : IRule
{
    public void UpdateQuality(Item item)
    {
        item.SellIn -= 1;

        if (item.Quality < 50)
        {
            item.Quality += 1;

            if (item.SellIn < 0 && item.Quality < 50)
            {
                item.Quality += 1; // Extra increase after expiration
            }
        }
    }
}
