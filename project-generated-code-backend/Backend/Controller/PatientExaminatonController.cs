// File:    PatientExaminatonController.cs
// Author:  Luka Doric
// Created: Sunday, June 7, 2020 4:19:02 PM
// Purpose: Definition of Class PatientExaminatonController

using Backend.Model.Accounts;
using System;
using System.Collections.Generic;

namespace Backend.Controller
{
   public class PatientExaminatonController
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
      
      public Backend.Service.PatientExaminationService patientExaminationService;
   
   }
}