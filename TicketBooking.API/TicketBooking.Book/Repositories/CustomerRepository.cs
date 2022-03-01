using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TicketBooking.Book.Contexts;
using TicketBooking.Book.Entities;
using TicketBooking.Data;

namespace TicketBooking.Book.Repositories
{
    public class CustomerRepository : Repository<Customer, Guid>, ICustomerRepository
    {
        public CustomerRepository(BookDbContext context)
            : base((DbContext)context)
        {

        }
    }
}
