﻿using System;
using System.Collections.Generic;
using System.Text;
using Nop.Web.Framework.Models;

namespace Nop.Plugin.Tutorial.DistOfCustByCountry.Models
{
    public class CustomersDistribution : BaseNopModel
    {
        /// <summary>
        /// Country based on the billing address.
        /// </summary>
        public string Country { get; set; }

        /// <summary>
        /// Number of customers from specific country.
        /// </summary>
        public int NoOfCustomers { get; set; }
    }

}
