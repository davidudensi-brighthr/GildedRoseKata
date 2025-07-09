using GildedRoseKata;

namespace GildedRose.Rules
{
    public class ConjuredRule : IRule
    {
        public void UpdateQuality(Item item)
        {
            if (item.SellIn < 0)
            {
                item.Quality = item.Quality - Constants.NormalDecreaseRate_SellIn * 2;
            }
            else if (item.Quality >= Constants.NormalDecreaseRate_Quality * 2)
            {
                item.Quality = item.Quality - Constants.NormalDecreaseRate_Quality * 2;
            }
            else
            {
                item.Quality = 0;
            }
            item.SellIn = item.SellIn - 1;
        }
    }
}
