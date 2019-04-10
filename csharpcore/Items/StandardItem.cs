namespace csharpcore.Items
{
    class StandardItem : Item
    {
        public override void Update()
        {
            if (SellIn > 0)
            {
                Quality--;
            }
            else
            {
                // Once the sell by date has passed, Quality degrades twice as fast
                Quality -= 2;
            }
            
            DailyUpdate();
        }
    }
}
