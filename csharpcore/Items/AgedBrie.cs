namespace csharpcore.Items
{
    class AgedBrie : Item
    {
        public override void Update()
        {
            // "Aged Brie" actually increases in Quality the older it gets
            if (SellIn > 0)
            {
                Quality++;
            }
            // Once the sell by date has passed, Quality increases twice as fast
            else
            {
                Quality += 2;
            }

            DailyUpdate();
        }
    }
}
