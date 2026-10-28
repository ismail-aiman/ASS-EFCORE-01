using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ASS_EFCORE_01.Models
{
    public class Book
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public int ISBN { get; set; }
        public decimal Price { get; set; }
        public int NumberOfPages { get; set; }
        public int DatePublished { get; set; }
        public bool InStock { get; set; }
    }
}
