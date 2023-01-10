using AdapterPattern.SampleModel;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace AdapterPattern.BusinessObject
{
    public class CustomerManager
    {
        private List<Customer> _customers = new List<Customer>();

        public CustomerManager()
        {
            _customers.Add(new Customer { CustomerId = 1, Address = "Hyderbad", EmailId = "Sam@gmail.com", Name = "Sam", PhoneNumber = "040-2345678" });
            _customers.Add(new Customer { CustomerId = 2, Address = "Mumbai", EmailId = "Allen@gmail.com", Name = "Allen", PhoneNumber = "030-23422678" });
            _customers.Add(new Customer { CustomerId = 3, Address = "Kolkot", EmailId = "Smith@gmail.com", Name = "Smith", PhoneNumber = "020-23321998" });

        }

        public string GetCustomerData()
        {
            return JsonConvert.SerializeObject(_customers);
        }
    }
}
