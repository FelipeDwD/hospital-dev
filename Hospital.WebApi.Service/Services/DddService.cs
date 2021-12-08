using Hospital.WebApi.Domain.Interfaces.Services;
using System.Collections.Generic;
using System.Linq;

namespace Hospital.WebApi.Service.Services
{
    public class DddService : IDddService
    {
        private static readonly List<string> DddsValids = new List<string>            
            {
                "68", "82", "96", "92", "71", "85",
                "61", "27", "62", "98", "65", "67",
                "31", "91", "83", "41", "86", "21",
                "84", "51", "69", "95", "47", "11",
                "79", "63"
            };
        public bool IsValid(string cellPhone)
        {
            var ddd = GetDdd(cellPhone);
            return DddsValids.Contains(ddd);
        }

        public string GetDdd(string cellPhone)
        {
            var cellPhoneSplit = cellPhone.Split(new char[] { '(', ')' });
            return cellPhoneSplit[1];
        }
    }
}
