namespace Refactoring.ReplaceArrayWithObject
{
    public class Order
    {
        readonly string[] product = new string[3];

        public Order(string name, string price, string amount)
        {
            product[0] = name;
            product[1] = price;
            product[2] = amount;
        }

        public double GetTotalPrice()
        {
            return double.Parse(product[1]) * int.Parse(product[2]);
        }
    }
}
