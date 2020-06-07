// File:    PatientRepository.cs
// Author:  Luka Doric
// Created: Sunday, June 7, 2020 4:19:02 PM
// Purpose: Definition of Interface PatientRepository

using System;

namespace Backend.Repository
{
   public interface PatientRepository : GenericRepository<T>
   {
      List<Patient> GetPatientsByPhysitian(Backend.Model.Accounts.Physitian physitian);
   
   }
}