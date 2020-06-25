using Backend.Dto;
using Backend.Repository;
using HealthClinic.Backend.Model.Hospital;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HealthClinic.Backend.Repository
{
    public class RenovationFileSystem : GenericFileSystem<Renovation>, RenovationRepository
    {
        public RenovationFileSystem()
        {
            path = @"./../../../HealthClinic/data/renovations.txt";
        }
        public override Renovation Instantiate(string objectStringFormat)
        {
            return JsonConvert.DeserializeObject<Renovation>(objectStringFormat);
        }
    }
}
