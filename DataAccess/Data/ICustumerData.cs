using DataAccess.Models;

namespace DataAccess.Data
{
    public interface ICustomerData
    {
        Task Deleteustomer(int id);
        Task<Customer?> GetCustomer(int id);
        Task<IEnumerable<Customer>> GetCustomers();
        Task InsertCustomer(Customer customer);
        Task UpdateCustomer(Customer customer);
    }
}