using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Lanchonete.Entities;
using Lanchonete.Entities.Enums;

namespace Lanchonete.Entities
{
    class Order
    {
        public DateTime Moment { get; set; }
        public OrderStatus Status{get; set; }

        public Client Client { get; set; }
        List<OrderStatus> Orders { get; set; } = new List<OrderStatus>();

        public Order() { }
        public Order(DateTime moment, OrderStatus status, Client client)
        {
            Moment = moment;
            Status = status;
            Client = client;
        }

        public void addItem(OrderStatus orders)
        {
            Orders.Add(orders);
        }

        public void removeItem(OrderStatus ordes)
        {
            Orders.Add(ordes);
        }


       //FAZER O TOTAL DO PEDIDO

    }
}
