// File:    InpatientCareController.cs
// Author:  Luka Doric
// Created: Sunday, June 7, 2020 4:19:02 PM
// Purpose: Definition of Class InpatientCareController

using Backend.Dto;
using Model.Accounts;
using System;

namespace Backend.Controller
{
   public class InpatientCareController
   {
      private Physitian loggedPhysitian;
      
      public void StartInpatientCare(BedReservationDTO bedReservationDTO)
      {
         throw new NotImplementedException();
      }
      
      public void DischargeParient(Patient patient)
      {
         throw new NotImplementedException();
      }
      
      public Backend.Service.InpatientCareService inpatientCareService;
   
   }
}