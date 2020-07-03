using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LibraryFacilitator.ViewModel
{
    public class CheckinViewModel
    {
        public Guid Id { get; set; }
        public string Title { get; set; }
        public string ISBN { get; set; }
        public string PublishYear { get; set; }
        public string Price { get; set; }
        public bool IsCheckedIn { get; set; }

        public string FullName { get; set; }
        public string Phone { get; set; }
        public string NationalId { get; set; }
        public DateTime DateCheckedOut { get; set; }
        public DateTime ReturnDate { get; set; }

        public Guid BookId { get; set; }
    }
}
