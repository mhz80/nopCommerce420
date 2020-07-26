using System;
using System.Collections.Generic;
using System.Text;
using Nop.Plugin.Tutorial.DistOfCustByCountry.Models;

namespace Nop.Plugin.Tutorial.DistOfCustByCountry.Services
{
    public interface ICustomersByCountry
    {
        List<CustomersDistribution> GetCustomersDistributionByCountry();
    }
}
