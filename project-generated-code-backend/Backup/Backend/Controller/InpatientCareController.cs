// File:    InpatientCareController.cs
// Author:  Luka Doric
// Created: Sunday, June 7, 2020 4:19:02 PM
// Purpose: Definition of Class InpatientCareController

using System;

namespace Backend.Controller
{
   public class InpatientCareController
   {
      private Backend.Model.Accounts.Physitian loggedPhysitian;
      
      public void StartInpatientCare(BedReservationDTO bedReservationDTO)
      {
         throw new NotImplementedException();
      }
      
      public void DischargeParient(Backend.Model.Accounts.Patient patient)
      {
         throw new NotImplementedException();
      }
      
      public Backend.Service.InpatientCareService inpatientCareService;
   
   }
}