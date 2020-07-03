using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LibraryFacilitator.Models
{
    public class Book
    {
        public Guid Id { get; set; }
        public string Title { get; set; }
        public string ISBN { get; set; }
        public string PublishYear { get; set; }
        public string Price { get; set; }
        public bool IsCheckedIn { get; set; }
        
        public List<User> Users { get; set; }
    }
}
