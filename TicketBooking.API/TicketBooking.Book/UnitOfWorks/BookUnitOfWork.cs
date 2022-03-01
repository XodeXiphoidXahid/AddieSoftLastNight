using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TicketBooking.Book.Contexts;
using TicketBooking.Book.Repositories;
using TicketBooking.Data;

namespace TicketBooking.Book.UnitOfWorks
{
    public class BookUnitOfWork: UnitOfWork, IBookUnitOfWork
    {
        public ICustomerRepository Customers { get; private set; }

        public BookUnitOfWork(BookDbContext context,
            ICustomerRepository customers)
            : base(context)
        {
            Customers = customers;
            
        }


    }
}
