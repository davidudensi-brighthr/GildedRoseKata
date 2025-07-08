using GildedRoseKata;

namespace GildedRose.Rules
{
    public class NormalRule : IRule
    {
        public void UpdateQuality(Item item)
        {
            if (item.SellIn < 0)
            {
                item.Quality = item.Quality - 2;
            }
            else if (item.Quality > 0)
            {
                item.Quality = item.Quality - 1;
            }
            item.SellIn = item.SellIn - 1;
        }
    }
}
