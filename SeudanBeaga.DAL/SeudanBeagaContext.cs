using System.Data.Entity;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Data.Entity.Infrastructure;
using SeudanBeaga.DAL.Model;

namespace SeudanBeaga.DAL
{
    public class SeudanBeagaContext : DbContext
    {


        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Contact>().ToTable("Contacts");
            modelBuilder.Entity<Faq>().ToTable("Faq");
            modelBuilder.Entity<Holiday>().ToTable("Holidays");
        }
    }
}
