using Model.Schedule;
using Backend.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HCI_SIMS_PROJEKAT.Backend.Repository
{
    class ProcedureTypeFileSystem : GenericFileRepository<ProcedureType>, ProcedureTypeRepository
    {
        public override ProcedureType Instantiate(string objectStringFormat)
        {
            throw new NotImplementedException();
        }
    }
}
