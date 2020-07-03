using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using LibraryFacilitator.Models;
using LibraryFacilitator.ViewModel;

    public class LibraryContext : DbContext
    {
        public LibraryContext (DbContextOptions<LibraryContext> options)
            : base(options)
        {
        }

        public DbSet<Book> Books { get; set; }
        public DbSet<User> Users { get; set; }
        public DbSet<LibraryFacilitator.ViewModel.CheckinViewModel> CheckinViewModel { get; set; }
    }
