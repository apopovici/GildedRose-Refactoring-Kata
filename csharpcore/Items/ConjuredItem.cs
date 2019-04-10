namespace csharpcore.Items
{
    class ConjuredItem : Item
    {
        public override void Update()
        {
            if (SellIn > 0)
            {
                Quality -= 2;
            }
            else
            {
                // Once the sell by date has passed, Quality degrades twice as fast
                Quality -= 4;
            }

            DailyUpdate();
        }
    }
}
