namespace OnlineShop
{
    public class Order : IOrder
    {
        private ICalculatePrice calculate;

        public Order(ICalculatePrice calculate)
        {
            this.calculate = calculate;
        }

        public int OrderId { get; set; }

        public int Quantity { get; set; }

        public decimal Price { get; set; }      

        public void CreateOrder()
        {
            var order = new Order(this.calculate);
            order.Quantity = 1;
            order.Price = calculate.PriceCalculator();
            order.OrderId = 1;
            System.Console.WriteLine($"Order placed with OrderId {order.OrderId}and Price = {order.Price}");
        }       
    }
}
