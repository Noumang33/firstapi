using AutoMapper;
using WebAPi.Modal;
using WebAPi.Repos.Models;

namespace WebAPi.Helper
{
    public class AutoMapperHandler: Profile
    {
        public AutoMapperHandler() {
            CreateMap<TblCustomer, Customermodal>().ForMember(item=>item.Statusname, opt=>opt.MapFrom(
                item => (item.IsActive.Value && item.IsActive.Value) ? "Active" : "In active"));
        
        }
    }
}
