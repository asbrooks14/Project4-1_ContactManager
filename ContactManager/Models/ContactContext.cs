using System;
using Microsoft.EntityFrameworkCore;

namespace ContactManager.Models
{
    public class ContactContext : DbContext
    {
        public ContactContext(DbContextOptions<ContactContext> options)
            : base(options)
        { }

        public DbSet<Contact> Contacts { get; set; }
        public DbSet<Category> Categories { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Category>().HasData(
                new Category
                { CategoryId = 1, Name = "Family" },
                new Category
                { CategoryId = 2, Name = "Friend" },
                new Category
                { CategoryId = 3, Name = "Partner" },
                new Category
                { CategoryId = 4, Name = "Coworker" },
                new Category
                { CategoryId = 5, Name = "Other" }
                );

            modelBuilder.Entity<Contact>().HasData(
                new Contact
                {
                    ContactId = 1,
                    Firstname = "Caty",
                    Lastname = "Dogger",
                    PhoneNumber = "000-123-4567",
                    Email = "caty.dogger@yahoo.com",
                    Organization = "Organization 200",
                    CategoryId = 1,
                    DateAdded = DateTime.Now
                },

                new Contact
                {
                    ContactId = 2,
                    Firstname = "Fishy",
                    Lastname = "Tanks",
                    PhoneNumber = "000-222-4567",
                    Email = "fishy.tanks@gmail.com",
                    Organization = "Org A",
                    CategoryId = 2,
                    DateAdded = DateTime.Now
                },

                new Contact
                {
                    ContactId = 3,
                    Firstname = "Hamlet",
                    Lastname = "Burgers",
                    PhoneNumber = "000-444-4567",
                    Email = "hamlet.burgers@hotmail.com",
                    Organization = "Org B",
                    CategoryId = 3,
                    DateAdded = DateTime.Now
                },

                new Contact
                {
                    ContactId = 4,
                    Firstname = "Kermittacus",
                    Lastname = "Froggius",
                    PhoneNumber = "000-555-4567",
                    Email = "kermittacus.froggius@rocketmail.com",
                    Organization = "Muppets Inc.",
                    CategoryId = 4,
                    DateAdded = DateTime.Now
                },

                new Contact
                {
                    ContactId = 5,
                    Firstname = "Chocobo",
                    Lastname = "Latte",
                    PhoneNumber = "000-888-4567",
                    Email = "chocobo.latte@aol.com",
                    Organization = "Org C",
                    CategoryId = 5,
                    DateAdded = DateTime.Now
                }
                );
        }
    }
}
