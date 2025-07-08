using GildedRose.Rules;
using GildedRoseKata;

namespace GildedRoseTests
{
    public class AgedBrieRuleTests
    {
        [Fact]
        public void UpdateQuality_QualityShouldIncreaseByOne()
        {
            var item = new Item { Name = "+5 Dexterity Vest", SellIn = 10, Quality = 20 };
            var sut = new AgedBrieRule();
            sut.UpdateQuality(item);
            Assert.Equal(21, item.Quality);
        }

        [Fact]
        public void UpdateQuality_QualityShouldNotExceed_50()
        {
            var item = new Item { Name = "+5 Dexterity Vest", SellIn = 10, Quality = 49 };
            var sut = new AgedBrieRule();

            for (int i = 0; i < 10; i++)
            {
                sut.UpdateQuality(item);
            }
            Assert.Equal(50, item.Quality);
        }
    }
}
