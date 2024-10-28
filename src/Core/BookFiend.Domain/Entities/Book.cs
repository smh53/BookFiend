using BookFiend.Domain.BaseEntity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookFiend.Domain.Entities
{
    public class Book : BaseEntity.BaseEntity
    {
        public string Title { get; set; }
        public string ISBN { get; set; }
        public DateTime PublishedDate { get; set; }
        public string Publisher { get; set; }
        public int PageCount { get; set; }
        public string Language { get; set; }
        public string Description { get; set; }
        public string AuthorId { get; set; }
        public Author Author { get; set; }

    }
}
