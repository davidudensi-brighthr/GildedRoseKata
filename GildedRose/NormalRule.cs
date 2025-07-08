using GildedRoseKata;

namespace GildedRose
{
    public class NormalRule : IRule
    {
        public void UpdateQuality(Item item)
        {
            if (item.Quality > 0)
            {
                item.Quality = item.Quality - 1;
            }
            item.SellIn = item.SellIn - 1;
        }
    }
}
