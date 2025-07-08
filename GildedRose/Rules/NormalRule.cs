using GildedRoseKata;

namespace GildedRose.Rules
{
    public class NormalRule(int multiplier = 1) : IRule
    {
        public void UpdateQuality(Item item)
        {
            if (item.SellIn <= 0)
            {
                item.Quality = Math.Max(0, item.Quality - 2 * multiplier);
            }
            else if (item.Quality > 0)
            {
                item.Quality = item.Quality - 1 * multiplier;
            }
            item.SellIn = item.SellIn - 1;
        }
    }
}
