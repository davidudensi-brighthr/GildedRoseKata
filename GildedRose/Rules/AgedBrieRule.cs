using GildedRoseKata;

namespace GildedRose.Rules
{
    public class AgedBrieRule : IRule
    {
        public void UpdateQuality(Item item)
        {
            if (item.Quality < 50)
            {
                item.Quality = item.Quality + 1;
            }
        }
    }
}
