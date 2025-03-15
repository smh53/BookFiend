using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookFiend.Application.Features.Author.Shared
{
   public class BaseAuthor
    {
        public string Firstname { get; set; }
        public string Lastname { get; set; }
        public string Biography { get; set; }
        public string Nationality { get; set; }
        //public ICollection<Book> Books { get; set; } = new List<Book>();
    }
}
