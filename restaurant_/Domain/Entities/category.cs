using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace restaurant_.Domain.Entities
{
    public class category
    {
        public int Id { get; } // индификатоп
        public string Name { get; set; } // наимнование

        public category(int id) // конструтор
        {
            Id = id;
        }
    }
}
