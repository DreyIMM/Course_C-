using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Enumeracao.Entities;
using Enumeracao.Entities.Ennums;

namespace Enumeracao {
    class Program {
        static void Main(string[] args) {

            Order order = new Order
            {
                Id = 1080,
                Moment = DateTime.Now,
                Status = OrderStatus.Processing
            };

            Console.WriteLine(order);

            string txt = OrderStatus.PendingPayment.ToString();

            OrderStatus os = (OrderStatus)Enum.Parse(typeof(OrderStatus), "Delivered");


            Console.WriteLine(txt);
            Console.WriteLine(os);


        }
    }
}
