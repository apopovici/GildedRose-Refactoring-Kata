namespace csharpcore.Items
{
    class ConjuredItem : Item
    {
        public override void Update()
        {
            // Once the sell by date has passed, Quality degrades twice as fast
            Quality -= SellIn > 0 ? 2 : 4;

            DailyUpdate();
        }
    }
}
