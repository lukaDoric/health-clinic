using Model.Accounts;
using Backend.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HCI_SIMS_PROJEKAT.Backend.Repository
{
    public class SpecializationFileSystem : GenericFileRepository<Specialization>, SpecializationRepository
    {
        public override Specialization Instantiate(string objectStringFormat)
        {
            throw new NotImplementedException();
        }
    }
}
