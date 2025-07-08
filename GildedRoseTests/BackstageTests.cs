using GildedRose.Rules;
using GildedRoseKata;

namespace GildedRoseTests
{
    public class BackstageTests
    {
        [Fact]
        public void UpdateQuality_WhenSellInIs0_ShouldDropQualityToZero()
        {
            var item = new Item { Name = "foo", SellIn = 0, Quality = 10 };
            var sut = new BackstageRule();
            sut.UpdateQuality(item);
            Assert.Equal(0, item.Quality);
        }

        [Fact]
        public void UpdateQuality_WhenSellInIsLessThan5_QualityShouldIncreaseBy3()
        {
            var item = new Item { Name = "foo", SellIn = 3, Quality = 10 };
            var sut = new BackstageRule();
            sut.UpdateQuality(item);
            Assert.Equal(13, item.Quality);
        }

        [Fact]
        public void UpdateQuality_WhenSellInIsLessThan10ButGreaterThan5_QualityShouldIncreaseBy2()
        {
            var item = new Item { Name = "foo", SellIn = 7, Quality = 10 };
            var sut = new BackstageRule();
            sut.UpdateQuality(item);
            Assert.Equal(12, item.Quality);
        }

        [Fact]
        public void UpdateQuality_WhenSellInIsAbove10_QualityShouldIncreaseBy1()
        {
            var item = new Item { Name = "foo", SellIn = 11, Quality = 10 };
            var sut = new BackstageRule();
            sut.UpdateQuality(item);
            Assert.Equal(11, item.Quality);
        }

        [Fact]
        public void UpdateQuality_QualityShouldNotExceed50()
        {
            var item = new Item { Name = "foo", SellIn = 11, Quality = 50 };
            var sut = new BackstageRule();
            sut.UpdateQuality(item);
            Assert.Equal(50, item.Quality);
        }
    }
}
