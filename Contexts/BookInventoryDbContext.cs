using Assignment_24_EF_Core.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Storage;
using System;
using System.Collections.Generic;
using System.Text;

namespace Assignment_24_EF_Core.Contexts
{
    public class BookInventoryDbContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server =(localdb)\\MSSQLLocalDB; Database = BookInventoryDB; Trusted_Connection = true; TrustServerCertificate = true");
        }

        //need the Book class to be a table in database
        public DbSet<Book> Books { get; set; }

       public DbSet<AutherInfo> AuthersInfo { get; set; }

        public DbSet<Category> Categories { get; set; }
    }
}
