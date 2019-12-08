namespace OnlineShop
{
    public class OrderGenerator : IOrderGenerator
    {
        private IOrder order;

        public OrderGenerator(IOrder order)
        {
            this.order = order;
        }

        public void PlaceOrder()
        {
            order.CreateOrder();            
        }
    }
}
