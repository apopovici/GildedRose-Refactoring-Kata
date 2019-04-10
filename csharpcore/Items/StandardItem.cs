namespace csharpcore.Items
{
    class StandardItem : Item
    {
        public override void Update()
        {
            // Once the sell by date has passed, Quality degrades twice as fast
            Quality -= SellIn > 0 ? 1 : 2;
            
            DailyUpdate();
        }
    }
}
