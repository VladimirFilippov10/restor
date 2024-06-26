using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using restaurant_.Domain.Entities;

namespace restaurant_.Domain.Entities
{
    public class product
    {
        public int Id { get; } // индификатор 
        public string Name { get; set; } // наименование
        public string Description { get; set; } // описание
        public List<category> Categories { get; set; } // категории
        public double ProteinPer100g { get; set; } // белок
        public double FatPer100g { get; set; } // жиры
        public double CarbsPer100g { get; set; } // углеводы
        public int Calories { get; set; } // каллории 
        public double Price { get; set; } // цена

        public product(int id) // конструтор
        {
            Id = id;
            Categories = new List<category>();
        }
    }
}
