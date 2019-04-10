namespace csharpcore.Items
{
    class AgedBrie : Item
    {
        public override void Update()
        {
            // "Aged Brie" actually increases in Quality the older it gets
            // Once the sell by date has passed, Quality increases twice as fast
            Quality += SellIn > 0 ? 1 : 2;

            DailyUpdate();
        }
    }
}
