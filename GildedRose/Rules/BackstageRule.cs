using GildedRoseKata;

namespace GildedRose.Rules
{
    public class BackstageRule : IRule
    {
        public void UpdateQuality(Item item)
        {
            item.SellIn -= 1;

            if (item.SellIn < 0)
            {
                item.Quality = 0;
                return;
            }

            int increase = 1;

            if (item.SellIn < 5)
            {
                increase = 3;
            }
            else if (item.SellIn < 10)
            {
                increase = 2;
            }

            item.Quality = Math.Min(50, item.Quality + increase);
        }
    }
}
