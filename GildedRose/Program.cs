using GildedRose.Rules;

namespace GildedRoseKata;

public class Program
{
    public static void Main(string[] args)
    {
        Console.WriteLine("OMGHAI!");

        var items = new Dictionary<Item, IRule>();
        var item1 = new Item { Name = "+5 Dexterity Vest", SellIn = 10, Quality = 20 };
        items.Add(item1, new NormalRule());

        var item2 = new Item { Name = "Aged Brie", SellIn = 2, Quality = 0 };
        items.Add(item2, new AgedBrieRule());

        var item3 = new Item { Name = "Elixir of the Mongoose", SellIn = 5, Quality = 7 };
        items.Add(item3, new NormalRule());

        var item4 = new Item { Name = "Sulfuras, Hand of Ragnaros", SellIn = 0, Quality = 80 };
        items.Add(item4, null);

        var item5 = new Item { Name = "Sulfuras, Hand of Ragnaros", SellIn = -1, Quality = 80 };
        items.Add(item5, null);

        var item6 = new Item
        {
            Name = "Backstage passes to a TAFKAL80ETC concert",
            SellIn = 15,
            Quality = 20
        };
        items.Add(item6, new BackstageRule());

        var item7 = new Item
        {
            Name = "Backstage passes to a TAFKAL80ETC concert",
            SellIn = 10,
            Quality = 49
        };
        items.Add(item7, new BackstageRule());

        var item8 = new Item
        {
            Name = "Backstage passes to a TAFKAL80ETC concert",
            SellIn = 5,
            Quality = 49
        };
        items.Add(item8, new BackstageRule());
        // this conjured item does not work properly yet

        var item9 = new Item { Name = "Conjured Mana Cake", SellIn = 3, Quality = 6 };
        //dictionary.Add(item1, new BackstageRule());





        //Console.WriteLine("OMGHAI!");

        //List<Item> Items =
        //[
        //    new Item { Name = "+5 Dexterity Vest", SellIn = 10, Quality = 20 },
        //    new Item { Name = "Aged Brie", SellIn = 2, Quality = 0 },
        //    new Item { Name = "Elixir of the Mongoose", SellIn = 5, Quality = 7 },
        //    new Item { Name = "Sulfuras, Hand of Ragnaros", SellIn = 0, Quality = 80 },
        //    new Item { Name = "Sulfuras, Hand of Ragnaros", SellIn = -1, Quality = 80 },
        //    new Item
        //    {
        //        Name = "Backstage passes to a TAFKAL80ETC concert",
        //        SellIn = 15,
        //        Quality = 20
        //    },

        //    new Item
        //    {
        //        Name = "Backstage passes to a TAFKAL80ETC concert",
        //        SellIn = 10,
        //        Quality = 49
        //    },

        //    new Item
        //    {
        //        Name = "Backstage passes to a TAFKAL80ETC concert",
        //        SellIn = 5,
        //        Quality = 49
        //    },
        //    // this conjured item does not work properly yet

        //    new Item { Name = "Conjured Mana Cake", SellIn = 3, Quality = 6 }
        //];

        var app = new GildedRoseService(items);

        for (var i = 0; i < 31; i++)
        {
            Console.WriteLine("-------- day " + i + " --------");
            Console.WriteLine("name, sellIn, quality");
            //for (var j = 0; j < items.Count; j++)
            //{
            //    System.Console.WriteLine(items[j].Name + ", " + Items[j].SellIn + ", " + Items[j].Quality);
            //}
            Console.WriteLine("");
            app.UpdateQuality();
        }
    }
}
