using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace restaurant_.Domain.Entities
{
    public class orderItem
    {
        public int Id { get; } // индификатор
        public order numbweOrder { get; set; } // номер заказа
        public product product { get; set; } // блюдо
        public int quantity { get; set; } // количество 
        public double productPrice { get; set; } // цена 

        public orderItem(int id)
        {
            Id = id;
        }
    }
}
