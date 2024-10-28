using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookFiend.Domain.Entities
{
    public class Author : BaseEntity.BaseEntity
    {
        public string Firstname { get; set; }
        public string Lastname { get; set; }
        public string Biography { get; set; }
        public string Nationality { get; set; }
        public ICollection<Book> Books { get; set; } = new List<Book>();

    }
}
