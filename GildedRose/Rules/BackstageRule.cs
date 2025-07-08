using GildedRoseKata;

namespace GildedRose.Rules
{
    public class BackstageRule : IRule
    {
        public void UpdateQuality(Item item)
        {
            if (item.Quality == 50)
                return;

            if (item.SellIn == 0)
            {
                item.Quality = 0;
                return;
            }

            if (item.SellIn < 5)
            {
                item.Quality = item.Quality + 3;
                return;
            }

            if (item.SellIn < 10)
            {
                item.Quality = item.Quality + 2;
                return;
            }

            item.Quality = item.Quality + 1;
        }
    }
}
