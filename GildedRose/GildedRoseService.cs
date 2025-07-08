using GildedRose.Rules;

namespace GildedRoseKata;

public class GildedRoseService
{
    private IDictionary<Item, IRule> _items;
    public GildedRoseService(IDictionary<Item, IRule> items)
    {
        _items = items;
    }

    public void UpdateQuality()
    {
        foreach (var item in _items)
        {
            var rule = item.Value;
            rule.UpdateQuality(item.Key);
        }
    }
}
