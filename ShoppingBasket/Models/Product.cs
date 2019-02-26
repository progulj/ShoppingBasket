namespace ShoppingBasktComponent.Models
{
    class Product
    {
        public string Name { get; set; }
        public double ItemPrice { get; set; }
        public int ProductType { get; set; }
        public int NumberOfItems { get; set; }

        public Product(string Name, double ItemPrice, int ProductType, int NumberOfItems)
        {
            this.Name = Name;
            this.ItemPrice = ItemPrice;
            this.ProductType = ProductType;
            this.NumberOfItems = NumberOfItems;
        }

    }
}
