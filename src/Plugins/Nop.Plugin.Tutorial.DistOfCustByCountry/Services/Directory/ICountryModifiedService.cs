using System;
using System.Collections.Generic;
using System.Text;
using Nop.Core.Domain.Common;
using Nop.Core.Domain.Directory;
using Nop.Services.Directory;

namespace Nop.Plugin.Tutorial.DistOfCustByCountry.Services.Directory
{
    public interface ICountryModifiedService : ICountryService
    {
        Country GetCountryByAddress(Address address);
    }
}
