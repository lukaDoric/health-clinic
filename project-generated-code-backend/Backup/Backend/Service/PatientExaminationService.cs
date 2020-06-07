// File:    PatientExaminationService.cs
// Author:  Luka Doric
// Created: Sunday, June 7, 2020 4:19:02 PM
// Purpose: Definition of Class PatientExaminationService

using System;

namespace Backend.Service
{
   public class PatientExaminationService
   {
      private Backend.Model.Accounts.Physitian loggedPhysitian;
      
      public Backend.Model.Accounts.Patient GetPatient(string id)
      {
         throw new NotImplementedException();
      }
      
      public List<Patient> GetPatientList()
      {
         throw new NotImplementedException();
      }
      
      public Backend.Repository.PatientRepository patientRepository;
   
   }
}