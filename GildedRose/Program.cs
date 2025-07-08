using GildedRose.Rules;

namespace GildedRoseKata;

public class Program
{
    public static void Main(string[] args)
    {
        Console.WriteLine("OMGHAI!");

        Dictionary<Item, IRule> items = new()
        {
            { new Item { Name = "+5 Dexterity Vest", SellIn = 10, Quality = 20 }, new NormalRule() },
            { new Item { Name = "Aged Brie", SellIn = 2, Quality = 0 }, new AgedBrieRule() },
            { new Item { Name = "Elixir of the Mongoose", SellIn = 5, Quality = 7 }, new NormalRule() },
            { new Item { Name = "Sulfuras, Hand of Ragnaros", SellIn = 0, Quality = 80 }, null },
            { new Item { Name = "Sulfuras, Hand of Ragnaros", SellIn = -1, Quality = 80 }, null },
            { new Item
                {
                    Name = "Backstage passes to a TAFKAL80ETC concert",
                    SellIn = 15,
                    Quality = 20
                },
                new BackstageRule()
            },           
            { new Item
                {
                    Name = "Backstage passes to a TAFKAL80ETC concert",
                    SellIn = 10,
                    Quality = 49
                },
                new BackstageRule()
            },
            {            new Item
                {
                    Name = "Backstage passes to a TAFKAL80ETC concert",
                    SellIn = 5,
                    Quality = 49
                },
                new BackstageRule()
            },
            { new Item { Name = "Conjured Mana Cake", SellIn = 3, Quality = 6 }, new NormalRule()}

        };

        var app = new GildedRoseService(items);

        for (var i = 0; i < 31; i++)
        {
            Console.WriteLine("-------- day " + i + " --------");
            Console.WriteLine("name, sellIn, quality");
            foreach (var item in items.Keys)
            {
                Console.WriteLine(item.Name + ", " + item.SellIn + ", " + item.Quality);
            }
            Console.WriteLine("");
            app.UpdateQuality();
        }
    }
}
