using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exam_entity.Entities
{
    public class Book
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public int Pages { get; set; }
        public int PublicationYear { get; set; }
        public string? Comment { get; set; }

        public int? AuthorId { get; set; }
        public Author Author { get; set; }

        public int? GenreId { get; set; }
        public Genre Genre { get; set; }

        public int? BookInStoreId { get; set; }
        public BookInStore BookInStore { get; set; }
    }

}
