using WebAPi.Repos.Models;
using WebAPi.Repos;
using WebAPi.Service;
using WebAPi.Modal;
using AutoMapper;

namespace WebAPi.Container
{
    public class CustomerService : ICustomerService
    {
        private readonly LearndataContextb context;
        private readonly IMapper mapper;
        public CustomerService(LearndataContextb context, IMapper mapper)
        {
            this.context = context;
            this.mapper = mapper;
        }
        public List<Customermodal> GetAll()
        { List <Customermodal> _response = new List <Customermodal> ();
           var _data=  this.context.TblCustomers.ToList();
            if (_data != null )
            {
                _response= this.mapper.Map<List<TblCustomer>,List<Customermodal>>(_data);
            }
            return _response;   
        }
    }
}
