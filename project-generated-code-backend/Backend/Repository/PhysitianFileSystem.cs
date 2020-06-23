// File:    PhysitianFileSystem.cs
// Author:  Luka Doric
// Created: Sunday, June 7, 2020 4:19:02 PM
// Purpose: Definition of Class PhysitianFileSystem

using Model.Accounts;
using Newtonsoft.Json;
using System;

namespace Backend.Repository
{
    public class PhysitianFileSystem : GenericFileSystem<Physitian>, PhysitianRepository
    {
        public PhysitianFileSystem()
        {
            path = @"./../../../../project-generated-code-backend/data/physitians.txt";
        }
        public Specialization GetPhysitiansByProcedureType(Specialization procedureType)
        {
            throw new NotImplementedException();
        }

        public override Physitian Instantiate(string objectStringFormat)
        {
            return JsonConvert.DeserializeObject<Physitian>(objectStringFormat);
        }
    }
}