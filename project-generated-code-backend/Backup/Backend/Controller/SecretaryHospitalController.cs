// File:    SecretaryHospitalController.cs
// Author:  Luka Doric
// Created: Sunday, June 7, 2020 4:19:02 PM
// Purpose: Definition of Class SecretaryHospitalController

using System;

namespace Backend.Controller
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
      
      public Backend.Service.HospitalService hospitalService;
   
   }
}