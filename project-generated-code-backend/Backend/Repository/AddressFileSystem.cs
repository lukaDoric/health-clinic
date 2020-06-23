using Model.Util;
using Backend.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HCI_SIMS_PROJEKAT.Backend.Repository
{
    public class AddressFileSystem : GenericFileRepository<Address>, AddressRepository
    {
        public override Address Instantiate(string objectStringFormat)
        {
            throw new NotImplementedException();
        }
    }
}
