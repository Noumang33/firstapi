using WebAPi.Helper;
using WebAPi.Modal;
using WebAPi.Repos.Models;

namespace WebAPi.Service
{
    public interface ICustomerService
    {
        Task<List<Customermodal>> GetAll();
        Task <Customermodal> Getbycode(string code);
        Task<APIResponse> Remove(string code);
        Task<APIResponse> Create(Customermodal data);
        Task<APIResponse> Update(Customermodal data, string code);

    }
}