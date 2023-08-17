using Nomi.Repos;
using Nomi.Repos.Models;
using Nomi.Service;

namespace Nomi.Container
{
    public class CustomerService : ICustomerService
    {
        private readonly LearndataContextb context;
        public CustomerService(LearndataContextb context) {
        this.context = context;
        }
        public List<TblCustomer> GetAll() => this.context.TblCustomers.ToList();
    }
}
