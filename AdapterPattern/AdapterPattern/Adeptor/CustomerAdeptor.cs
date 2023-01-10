using AdapterPattern.BusinessObject;
using AdapterPattern.DTO;
using AdapterPattern.SampleModel;
using Newtonsoft.Json;
using System.Collections.Generic;
using System.Linq;

namespace AdapterPattern.Adeptor
{
    internal class CustomerAdeptor : CustomerManager, ICustomer
    {

        public IEnumerable<CustomerDTO> GetCustomers()
        {
            var data=base.GetCustomerData();
            IEnumerable<Customer> customer= JsonConvert.DeserializeObject<IEnumerable<Customer>>(data);

            return customer.Select(x => new CustomerDTO
            {
                Address = x.Address,
                EmailId = x.EmailId,
                FullName = x.Name,
                Id = x.CustomerId,
                PhoneNumber = x.PhoneNumber
            });
        }
    }
}
