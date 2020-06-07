// File:    PhysitianRepository.cs
// Author:  Luka Doric
// Created: Sunday, June 7, 2020 4:19:02 PM
// Purpose: Definition of Interface PhysitianRepository

using System;

namespace Backend.Repository
{
   public interface PhysitianRepository : GenericRepository<T>
   {
      specialization GetPhysitiansByProcedureType(Backend.Model.Accounts.Specialization procedureType);
   
   }
}