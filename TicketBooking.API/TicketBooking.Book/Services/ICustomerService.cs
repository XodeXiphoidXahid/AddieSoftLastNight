using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TicketBooking.Book.BusinessObjects;

namespace TicketBooking.Book.Services
{
    public interface ICustomerService
    {
   
        List<Customer> GetAllCustomer();
        Customer GetSingleCustomer(Guid id);
        Guid CreateCustomer(Customer customer);
        void UpdateCustomer(Guid id, Customer customer);
    }
}