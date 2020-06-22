// File:    PatientRegistrationController.cs
// Author:  Luka Doric
// Created: Sunday, June 7, 2020 4:19:02 PM
// Purpose: Definition of Class PatientRegistrationController

using Backend.Dto;
using Backend.Service.HospitalAccountsService;
using Model.Accounts;
using System;

namespace Backend.Controller
{
   public class PatientRegistrationController
   {
      public void RegisterPatient(PatientDTO patientDTO)
      {
         throw new NotImplementedException();
      }
      
      public void DeletePatientAccount(Patient patient)
      {
         throw new NotImplementedException();
      }
      
      public PatientRegistrationService patientRegistrationService;
   
   }
}