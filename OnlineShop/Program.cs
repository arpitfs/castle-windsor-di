using Castle.MicroKernel.Registration;
using Castle.Windsor;
using System;


namespace OnlineShop
{
    static class Program 
    {
        static void Main(string[] args)
        {
            var container = new WindsorContainer();

            container.Register(Component.For<IOrder>().ImplementedBy<Order>());
            container.Register(Component.For<ICalculatePrice>().ImplementedBy<CalculatePrice>());
            container.Register(Component.For<IOrderGenerator>().ImplementedBy<OrderGenerator>());

            var orderGenerator = container.Resolve<IOrderGenerator>();
            orderGenerator.PlaceOrder();

            Console.ReadKey();
        }
    }
}
