using WebAPi.Repos.Models;
using WebAPi.Repos;
using WebAPi.Service;
using WebAPi.Modal;
using AutoMapper;
using Microsoft.EntityFrameworkCore;
using WebAPi.Helper;
using static System.Runtime.InteropServices.JavaScript.JSType;

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

        public async Task<APIResponse> Create(Customermodal data)
        {
            APIResponse response = new APIResponse();
            try
            {
                TblCustomer _customer = this.mapper.Map<Customermodal, TblCustomer>(data);
                await this.context.TblCustomers.AddAsync(_customer);
                await this.context.SaveChangesAsync();
                response.ResponseCode = 201;
                response.Result = data.Code;
                   
            }
            catch (Exception ex)
            {
                response.ResponseCode = 400;
                response.ErrorMessage = ex.Message;
            }
            return response;
        }

        public async Task<List<Customermodal>> GetAll()
        { List <Customermodal> _response = new List <Customermodal> ();
           var _data=  await this.context.TblCustomers.ToListAsync();
            if (_data != null )
            {
                _response= this.mapper.Map<List<TblCustomer>,List<Customermodal>>(_data);
            }
            return _response;   
        }

        public async Task<Customermodal> Getbycode(string code)
        {
            Customermodal _response = new Customermodal();
            var _data = await this.context.TblCustomers.FindAsync(code);
            if (_data != null)
            {
                _response = this.mapper.Map<TblCustomer, Customermodal>(_data);
            }
            return _response;
        }

        public async Task<APIResponse> Remove(string code)
        {
            APIResponse response = new APIResponse();
            try
            {
                
                var _customer = await this.context.TblCustomers.FindAsync(code);
                
                if (_customer != null)
                {
                    this.context.TblCustomers.Remove(_customer);
                    await this.context.SaveChangesAsync();
                    response.ResponseCode = 200;
                    response.Result = code;
                }
                else
                {
                    response.ResponseCode = 404;
                    response.ErrorMessage = "Data Not Found";

                }

            }
            catch (Exception ex)
            {
                response.ResponseCode = 400;
                response.ErrorMessage = ex.Message;
            }
            return response;
        }

        public async Task<APIResponse> Update(Customermodal data, string code)
        {
            APIResponse response = new APIResponse();
            try
            {

                var _customer = await this.context.TblCustomers.FindAsync(code);

                if (_customer != null)
                {
                    _customer.Name = data.Name;
                    _customer.Email = data.Email;
                    _customer.PhoneNumber = data.PhoneNumber;
                    _customer.IsActive = data.IsActive;
                    _customer.CreditLimit = data.CreditLimit;

                    await this.context.SaveChangesAsync();
                    response.ResponseCode = 200;
                    response.Result = code;
                }
                else
                {
                    response.ResponseCode = 404;
                    response.ErrorMessage = "Data Not Found";

                }

            }
            catch (Exception ex)
            {
                response.ResponseCode = 400;
                response.ErrorMessage = ex.Message;
            }
            return response;
        }
    }
}
