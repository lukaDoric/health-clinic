// File:    PatientRegistrationService.cs
// Author:  Luka Doric
// Created: Sunday, June 7, 2020 4:19:02 PM
// Purpose: Definition of Class PatientRegistrationService

using System;

namespace Backend.Service
{
   public class PatientRegistrationService
   {
      private bool IsJMBGValid(String jmbg)
      {
         throw new NotImplementedException();
      }
      
      private bool IsGuestAccount(Backend.Model.Accounts.Patient patient)
      {
         throw new NotImplementedException();
      }
      
      public void RegisterPatient(PatientDTO patientDTO)
      {
         throw new NotImplementedException();
      }
      
      public void DeletePatientAccount(Backend.Model.Accounts.Patient patient)
      {
         throw new NotImplementedException();
      }
      
      public Backend.Repository.PatientRepository patientRepository;
   
   }
}