// File:    HospitalService.cs
// Author:  Luka Doric
// Created: Sunday, June 7, 2020 4:19:02 PM
// Purpose: Definition of Class HospitalService

using System;

namespace Backend.Service
{
   public class HospitalService
   {
      public List<Patient> GetAllPatients()
      {
         throw new NotImplementedException();
      }
      
      public List<Physitian> GetAllPhysitians()
      {
         throw new NotImplementedException();
      }
      
      public List<Patient> GetPatientsByPhysitian(Backend.Model.Accounts.Patient physitian)
      {
         throw new NotImplementedException();
      }
      
      public List<Secretary> GetSecretaries()
      {
         throw new NotImplementedException();
      }
      
      public Backend.Repository.PatientRepository patientRepository;
      public Backend.Repository.PhysitianRepository physitianRepository;
   
   }
}