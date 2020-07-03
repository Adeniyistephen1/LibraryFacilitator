using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LibraryFacilitator.Models
{
    public class User
    {
        public Guid Id { get; set; }
        public string FullName { get; set; }
        public string Phone { get; set; }
        public string NationalId { get; set; }
        public DateTime DateCheckedOut { get; set; }
        public DateTime ReturnDate { get; set; }

        public Guid BookId { get; set; }
        public Book Books { get; set; }
    }
}
