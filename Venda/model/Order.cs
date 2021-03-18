using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Venda.enums;

namespace Venda.model
{
    class Order
    {
        public long Id { get; set; }
        public DateTime Moment { get; set; }
        public OrderStatus Status { get; set; }
        public List<OrderItem> OrderItens { get; set; }

        public void AddOrderItem(OrderItem orderItem)
        {
            OrderItens.Add(orderItem);
        }

        public void RemoveOrderItem(OrderItem orderItem)
        {
            OrderItens.Remove(orderItem);
        }

        public double Total()
        {
            double soma = 0;
            OrderItens.ForEach(order => soma += (order.Quantity * order.Price));
            return soma;
        }


        public override string ToString()
        {
            return $"Id: {Id}, moment: {Moment}, status: {Status}";
        }
    }
}
