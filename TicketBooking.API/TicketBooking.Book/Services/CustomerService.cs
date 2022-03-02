using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TicketBooking.Book.BusinessObjects;
using TicketBooking.Book.UnitOfWorks;

namespace TicketBooking.Book.Services
{
    public class CustomerService : ICustomerService
    {
        private readonly IBookUnitOfWork _bookUnitOfWork;
        
        public CustomerService(IBookUnitOfWork bookUnitOfWork)
        {
            _bookUnitOfWork = bookUnitOfWork;
        }

        public Guid CreateCustomer(Customer customer)
        {
            _bookUnitOfWork.Customers.Add(new Entities.Customer
            {

                Id = Guid.NewGuid(),
                Name=customer.Name

            });

            var newCustomer = new Entities.Customer
            {
                Id = Guid.NewGuid(),
                Name = customer.Name
            };

            _bookUnitOfWork.Customers.Add(newCustomer);
            return newCustomer.Id;



        }

        public List<Customer> GetAllCustomer()
        {
            var customerList = _bookUnitOfWork.Customers.GetAll();

            var resultData = (from customer in customerList
                              select new Customer
                              {
                                  Id = customer.Id,
                                  Name = customer.Name
                              }).ToList();

            return resultData;
        }

        public Customer GetSingleCustomer(Guid id)
        {
            var customer = _bookUnitOfWork.Customers.GetById(id);

            return new Customer
            {
                Id = customer.Id,
                Name = customer.Name,
                Age = customer.Age
            };
        }

        public void UpdateCustomer(Guid id, Customer customer)
        {
            var rercord = _bookUnitOfWork.Customers.GetById(id);

            
        }
    }
}
