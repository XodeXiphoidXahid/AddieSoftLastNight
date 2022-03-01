using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TicketBooking.Book.Repositories;
using TicketBooking.Data;

namespace TicketBooking.Book.UnitOfWorks
{
    public interface IBookUnitOfWork: IUnitOfWork
    {
        ICustomerRepository Customers { get; }
    }
}
