using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ASS_EFCORE_01.Models
{
    public class Author
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public string ShortBio { get; set; }
        public DateTime DateOfBirth { get; set; }
        public int MyProperty1 { get; set; }

    }
}
