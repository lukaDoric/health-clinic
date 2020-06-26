// File:    PhysitianRepository.cs
// Author:  Luka Doric
// Created: Sunday, June 7, 2020 4:19:02 PM
// Purpose: Definition of Interface PhysitianRepository

using Model.Accounts;
using System;

namespace Backend.Repository
{
   public interface PhysitianRepository : GenericRepository<Physitian>
   {
      Specialization GetPhysitiansByProcedureType(Specialization procedureType);
   
   }
}