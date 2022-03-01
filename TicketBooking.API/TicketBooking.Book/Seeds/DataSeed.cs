using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TicketBooking.Book.Entities;

namespace TicketBooking.Book.Seeds
{
    public static class DataSeed
    {
        public static void seed(this ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Customer>()
                .HasData(
                new Customer
                {
                    Id = Guid.NewGuid(),
                    Name = "Zahid",
                    Address = "Kolabagan",
                    Age = 26,
                    Salary = 20000
                },

                new Customer
                {
                    Id = Guid.NewGuid(),
                    Name = "Jui",
                    Address = "Khulna",
                    Age = 15,
                    Salary = 1500
                },

                new Customer
                {
                    Id = Guid.NewGuid(),
                    Name = "Rafsan",
                    Address = "BUET",
                    Age = 20,
                    Salary = 30000
                },
                new Customer
                {
                    Id = Guid.NewGuid(),
                    Name = "Habib",
                    Address = "Comila",
                    Age = 40,
                    Salary = 50000
                }
                );


        }
    }
}
