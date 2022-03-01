using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TicketBooking.Book.Entities;
using TicketBooking.Data;

namespace TicketBooking.Book.Repositories
{
    public interface ICustomerRepository : IRepository<Customer, Guid>
    {

    }
}
