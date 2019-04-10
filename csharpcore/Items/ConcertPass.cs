namespace csharpcore.Items
{
    class ConcertPass : Item
    {
        public override void Update()
        {
            if (SellIn <= 0)
            {
                Quality = 0;
            }
            else if (SellIn <= 5)
            {
                Quality += 3;
            }
            else if (SellIn <= 10)
            {
                Quality += 2;
            }
            else
            {
                Quality++;
            }

            DailyUpdate();
        }
    }
}
