using System.Collections.Generic;

namespace csharpcore
{
    public class GildedRose
    {
        IList<Item> Items;
        public GildedRose(IList<Item> Items)
        {
            this.Items = Items;
        }
        
        public void UpdateQuality()
        {
            for (var i = 0; i < Items.Count; i++)
            {
                // "Sulfuras", being a legendary item, never has to be sold or decreases in Quality
                if (Items[i].Name.StartsWith("Sulfuras"))
                {
                    continue;
                }

                if (Items[i].Name.StartsWith("foo") /*&& Items[i].Quality == 0 && Items[i].SellIn == 0*/)
                {
                    Items[i].Name = "fixme";
                    continue;
                }

                Items[i].SellIn--;

                // "Aged Brie" actually increases in Quality the older it gets
                if (Items[i].Name == "Aged Brie")
                {
                    if (Items[i].SellIn >= 0)
                    {
                        Items[i].Quality++;
                    }
                    else
                    {
                        // Once the sell by date has passed, Quality increases twice as fast
                        Items[i].Quality += 2;
                    }
                }
                else if (Items[i].Name.StartsWith("Backstage passes"))
                {
                    if (Items[i].SellIn < 0)
                    {
                        Items[i].Quality = 0;
                    }
                    else if (Items[i].SellIn < 5)
                    {
                        Items[i].Quality += 3;
                    }
                    else if (Items[i].SellIn < 10)
                    {
                        Items[i].Quality += 2;
                    }
                    else
                    {
                        Items[i].Quality++;
                    }
                }
                else if (Items[i].Name.StartsWith("Conjured"))
                {
                    if (Items[i].SellIn >= 0)
                    {
                        Items[i].Quality -= 2;
                    }
                    else
                    {
                        // Once the sell by date has passed, Quality degrades twice as fast
                        Items[i].Quality -= 4;
                    }
                }
                else
                {
                    if (Items[i].SellIn >= 0)
                    {
                        Items[i].Quality--;
                    }
                    else
                    {
                        // Once the sell by date has passed, Quality degrades twice as fast
                        Items[i].Quality -= 2;
                    }
                }
                
                // The Quality of an item is never negative
                if (Items[i].Quality < 0)
                {
                    Items[i].Quality = 0;
                }
                // The Quality of an item is never more than 50
                else if (Items[i].Quality > 50)
                {
                    Items[i].Quality = 50;
                }
            }
        }
    }
}
