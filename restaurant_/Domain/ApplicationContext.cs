using restaurant_.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace restaurant_.Domain
{
    public class ApplicationContext
    {
        public List<product> Products { get; set; } // список продуктов
        public List<category> Categories { get; set;} // категории
        public List<order> Order { get; set; } // заказ
        public List<orderItem> OrderItem { get; set; } // элементы заказа
    }
}
