namespace csharpcore
{
    public abstract class Item
    {
        public string Name { get; set; }
        public int SellIn { get; set; }
        public int Quality { get; set; }

        public abstract void Update();

        protected void DailyUpdate()
        {
            SellIn--;

            // The Quality of an item is never negative
            if (Quality < 0)
            {
                Quality = 0;
            }
            // The Quality of an item is never more than 50
            else if (Quality > 50)
            {
                Quality = 50;
            }
        }
    }
}
