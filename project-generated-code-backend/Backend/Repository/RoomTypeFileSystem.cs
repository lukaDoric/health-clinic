﻿using Model.Hospital;
using Backend.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HCI_SIMS_PROJEKAT.Backend.Repository
{
    class RoomTypeFileSystem : GenericFileRepository<RoomType>, RoomTypeRepository
    {
        public override RoomType Instantiate(string objectStringFormat)
        {
            throw new NotImplementedException();
        }
    }
}
