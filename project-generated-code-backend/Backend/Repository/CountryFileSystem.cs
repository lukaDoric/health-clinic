using Model.Util;
using Backend.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HCI_SIMS_PROJEKAT.Backend.Repository
{
    class CountryFileSystem : GenericFileRepository<Country>, CountryRepository
    {
        public override Country Instantiate(string objectStringFormat)
        {
            throw new NotImplementedException();
        }
    }
}
