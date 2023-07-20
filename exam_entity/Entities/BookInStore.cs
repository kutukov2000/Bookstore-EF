using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exam_entity.Entities
{
    public class BookInStore
    {
        public int Id { get; set; }
        public double Cost { get; set; }
        public double Price { get; set; }
        public int Discount { get; set; }
        public int Quantity { get; set; }

        public int BookId { get; set; }
        public Book Book { get; set; }
    }
}
