// File:    PhysitianScheduleController.cs
// Author:  Luka Doric
// Created: Sunday, June 7, 2020 4:19:02 PM
// Purpose: Definition of Class PhysitianScheduleController

using Backend.Dto;
using Backend.Model.Schedule;
using Backend.Service.SchedulingService;
using System;
using System.Collections.Generic;

namespace Backend.Controller.PhysitianControllers
{
   public class PhysitianScheduleController
   {
      private Backend.Model.Accounts.Physitian loggedPhysitian;
      
      public List<Appointment> GetAppointmentsByDate(DateTime date)
      {
         throw new NotImplementedException();
      }
      
      public Backend.Model.Schedule.Appointment NextAppointment()
      {
         throw new NotImplementedException();
      }
      
      public void NewAppointment(AppointmentDTO appointmentDTO)
      {
         throw new NotImplementedException();
      }
      
      public PhysitianScheduleService physitianScheduleService;
   
   }
}