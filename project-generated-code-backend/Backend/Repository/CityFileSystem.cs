﻿using Model.Util;
using Backend.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HCI_SIMS_PROJEKAT.Backend.Repository
{
    class CityFileSystem : GenericFileRepository<City>, CityRepository
    {
        public override City Instantiate(string objectStringFormat)
        {
            throw new NotImplementedException();
        }
    }
}
