using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace restaurant_.Domain.Entities
{
    public class order
    {
        public int id { get; set; } // индификатор
        public string orderNumber { get; set; } // номер заказа
        public List<orderItem> orderItems { get; set; } // элементы заказа
        public string Place { get; set; } // место получения
        public DateTime CreatedDate { get; set; } // дата заказа

        public order(int id)
        {
            id = id;
            orderItems = new List<orderItem>();

        }
    }
}
