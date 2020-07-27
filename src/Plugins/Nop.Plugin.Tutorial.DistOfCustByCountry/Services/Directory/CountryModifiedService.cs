using System;
using System.Collections.Generic;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Text;
using Nop.Core.Domain.Common;
using Nop.Core.Domain.Directory;
using Nop.Services.Directory;

namespace Nop.Plugin.Tutorial.DistOfCustByCountry.Services.Directory
{
    public class CountryModifiedService : ICountryModifiedService
    {
        private readonly ICountryService _countryService;
        public CountryModifiedService(ICountryService countryService)
        {
            _countryService = countryService;
        }

        public void DeleteCountry(Country country)
        {
            _countryService.DeleteCountry(country);
        }

        public IList<Country> GetAllCountries(int languageId = 0, bool showHidden = false)
        {
            return _countryService.GetAllCountries(languageId, showHidden);
        }

        public IList<Country> GetAllCountriesForBilling(int languageId = 0, bool showHidden = false)
        {
            return _countryService.GetAllCountriesForBilling(languageId, showHidden);
        }

        public IList<Country> GetAllCountriesForShipping(int languageId = 0, bool showHidden = false)
        {
            return _countryService.GetAllCountriesForShipping(languageId, showHidden);
        }

        public IList<Country> GetCountriesByIds(int[] countryIds)
        {
            return _countryService.GetCountriesByIds(countryIds);
        }

        public Country GetCountryByAddress(Address address)
        {
            return GetCountryById(address?.CountryId ?? 0);
        }

        public Country GetCountryById(int countryId)
        {
            return _countryService.GetCountryById(countryId);
        }

        public Country GetCountryByThreeLetterIsoCode(string threeLetterIsoCode)
        {
            return _countryService.GetCountryByThreeLetterIsoCode(threeLetterIsoCode);
        }

        public Country GetCountryByTwoLetterIsoCode(string twoLetterIsoCode)
        {
            return _countryService.GetCountryByTwoLetterIsoCode(twoLetterIsoCode);
        }

        public void InsertCountry(Country country)
        {
            _countryService.InsertCountry(country);
        }

        public void UpdateCountry(Country country)
        {
            _countryService.UpdateCountry(country);
        }
    }
}
