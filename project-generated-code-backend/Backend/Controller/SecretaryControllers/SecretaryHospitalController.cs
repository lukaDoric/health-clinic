// File:    SecretaryHospitalController.cs
// Author:  Luka Doric
// Created: Sunday, June 7, 2020 4:19:02 PM
// Purpose: Definition of Class SecretaryHospitalController

using Model.Accounts;
using Backend.Service.HospitalAccountsService;
using System;
using System.Collections.Generic;

namespace Backend.Controller.SecretaryControllers
{
   public class SecretaryHospitalController
   {
      public List<Patient> GetAllPatients()
      {
         throw new NotImplementedException();
      }
      
      public List<Physitian> GetAllPhysitians()
      {
         throw new NotImplementedException();
      }
      
      public HospitalService hospitalService;
   
   }
}