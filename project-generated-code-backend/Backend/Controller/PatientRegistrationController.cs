// File:    PatientRegistrationController.cs
// Author:  Luka Doric
// Created: Sunday, June 7, 2020 4:19:02 PM
// Purpose: Definition of Class PatientRegistrationController

using Backend.Dto;
using System;

namespace Backend.Controller
{
   public class PatientRegistrationController
   {
      public void RegisterPatient(PatientDTO patientDTO)
      {
         throw new NotImplementedException();
      }
      
      public void DeletePatientAccount(Backend.Model.Accounts.Patient patient)
      {
         throw new NotImplementedException();
      }
      
      public Backend.Service.PatientRegistrationService patientRegistrationService;
   
   }
}