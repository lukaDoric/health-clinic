// File:    AppointmentDTO.cs
// Author:  Luka Doric
// Created: Sunday, June 7, 2020 4:19:02 PM
// Purpose: Definition of Class AppointmentDTO

using Backend.Model.Accounts;
using Backend.Model.Hospital;
using Backend.Model.Schedule;
using Backend.Model.Util;
using System;

namespace Backend.Dto
{
   public class AppointmentDTO
   {
      private bool IsPreferedPhysitianSelected()
      {
         throw new NotImplementedException();
      }
      
      private bool IsPreferedTimeIntervalSelected()
      {
         throw new NotImplementedException();
      }
      
      private bool IsPreferedRoomSelected()
      {
         throw new NotImplementedException();
      }
      
      private ProcedureType procedureType;
      private TimeInterval dateTime;
      private Physitian physitian;
      private Patient patient;
      private Room room;
      private bool urgency;
      private bool timeRestriction;
   
   }
}