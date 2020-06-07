// File:    InpatientCareService.cs
// Author:  Luka Doric
// Created: Sunday, June 7, 2020 4:19:02 PM
// Purpose: Definition of Class InpatientCareService

using Backend.Dto;
using Backend.Model.Hospital;
using System;
using System.Collections.Generic;

namespace Backend.Service
{
   public class InpatientCareService
   {
      private List<Room> GetAvailableRooms(Backend.Model.Util.TimeInterval durationOfInpatientCare)
      {
         throw new NotImplementedException();
      }
      
      private List<Bed> GetAvailableBeds(Room room)
      {
         throw new NotImplementedException();
      }
      
      private Backend.Model.Accounts.Physitian loggedPhysitian;
      
      private Backend.Repository.RoomRepository roomRepository;
      
      public void StartInpatientCare(BedReservationDTO bedReservationDTO)
      {
         throw new NotImplementedException();
      }
      
      public void DischargeParient(Backend.Model.Accounts.Patient patient)
      {
         throw new NotImplementedException();
      }
      
      public Backend.Repository.InpatientCareRepository inpatientCareRepository;
   
   }
}