using Nomi.Repos.Models;

namespace Nomi.Service
{
    public interface ICustomerService
    {
        List<TblCustomer> GetAll();
    }
}
