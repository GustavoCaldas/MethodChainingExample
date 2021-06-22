namespace main.Models
{
    public class Pen
    {
        public string Color { get; private set; }
        public string Brand { get; private set; }
        public bool Used { get; private set; }

        public Pen HasColor(string color)
        {
            this.Color = color;
            return this;
        }

        public Pen HasBrand(string brand)
        {
            this.Brand = brand;
            return this;
        }

        public void IsUsed()
        {
            this.Used = true;
        }

        public void IsNew()
        {
            this.Used = false;
        }
    }
}