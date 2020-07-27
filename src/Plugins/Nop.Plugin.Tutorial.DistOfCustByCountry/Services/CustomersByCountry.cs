using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Nop.Plugin.Tutorial.DistOfCustByCountry.Models;
using Nop.Plugin.Tutorial.DistOfCustByCountry.Services.Directory;
using Nop.Services.Common;
using Nop.Services.Customers;
using Nop.Services.Directory;

namespace Nop.Plugin.Tutorial.DistOfCustByCountry.Services
{
    public class CustomersByCountry : ICustomersByCountry
    {
        private readonly IAddressService _addressService;
        private readonly ICountryModifiedService _countryService;
        private readonly ICustomerService _customerService;

        public CustomersByCountry(IAddressService addressService,
            ICountryModifiedService countryService,
            ICustomerService customerService)
        {
            _addressService = addressService;
            _countryService = countryService;
            _customerService = customerService;
        }

        public List<CustomersDistribution> GetCustomersDistributionByCountry()
        {
            return _customerService.GetAllCustomers()
                .Where(c => c.ShippingAddressId != null)
                .Select(c => new
                {
                    _countryService.GetCountryByAddress(_addressService.GetAddressById(c.ShippingAddressId ?? 0))
                        .Name,
                    c.Username
                })
                .GroupBy(c => c.Username)
                .Select(cbc => new CustomersDistribution { Country = cbc.Key, NoOfCustomers = cbc.Count() }).ToList();
        }
    }

}
