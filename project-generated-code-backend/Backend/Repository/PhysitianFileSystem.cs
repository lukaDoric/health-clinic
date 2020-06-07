// File:    PhysitianFileSystem.cs
// Author:  Luka Doric
// Created: Sunday, June 7, 2020 4:19:02 PM
// Purpose: Definition of Class PhysitianFileSystem

using Backend.Model.Accounts;
using System;

namespace Backend.Repository
{
    public class PhysitianFileSystem : GenericFileRepository<Physitian>, PhysitianRepository
    {
        public Specialization GetPhysitiansByProcedureType(Specialization procedureType)
        {
            throw new NotImplementedException();
        }
    }
}