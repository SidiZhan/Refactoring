namespace Refactoring.EncapsulateField
{
    public class Product
    {
        public Product(int id, string name, int price)
        {
            Id = id;
            Name = name;
            Price = price;
        }

        int Id;
        public string Name;
        public double Price;
    }
}