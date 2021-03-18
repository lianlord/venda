using System;
using Venda.enums;
using Venda.model;

namespace Venda {
    class Program {
        static void Main(string[] args) {
            Order order = new Order
            {
                Id = 1,
                Moment = DateTime.Now,
                Status = OrderStatus.PendingPayment
            };
            Console.WriteLine(order);
        }
    }
}
