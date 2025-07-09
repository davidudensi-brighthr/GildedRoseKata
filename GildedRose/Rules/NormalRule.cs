using GildedRoseKata;

namespace GildedRose.Rules
{
    public class NormalRule : IRule
    {
        public void UpdateQuality(Item item)
        {
            if (item.SellIn < 0)
            {
                item.Quality = item.Quality - Constants.NormalDecreaseRate_SellIn;
            }
            else if (item.Quality > 0)
            {
                item.Quality = item.Quality - Constants.NormalDecreaseRate_Quality;
            }
            item.SellIn = item.SellIn - 1;
        }
    }
}
