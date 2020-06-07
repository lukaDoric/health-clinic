// File:    AppointmentDTO.cs
// Author:  Luka Doric
// Created: Sunday, June 7, 2020 4:19:02 PM
// Purpose: Definition of Class AppointmentDTO

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
      
      private Backend.Model.Schedule.ProcedureType procedureType;
      private Backend.Model.Util.TimeInterval dateTime;
      private Backend.Model.Accounts.Physitian physitian;
      private Backend.Model.Accounts.Patient patient;
      private Backend.Model.Hospital.Room room;
      private bool urgency;
      private bool timeRestriction;
   
   }
}