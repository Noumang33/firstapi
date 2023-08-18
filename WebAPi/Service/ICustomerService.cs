using WebAPi.Modal;
using WebAPi.Repos.Models;

namespace WebAPi.Service
{
    public interface ICustomerService
    {
        List<Customermodal> GetAll();
    }
}