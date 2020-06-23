// File:    PhysitianScheduleController.cs
// Author:  Luka Doric
// Created: Sunday, June 7, 2020 4:19:02 PM
// Purpose: Definition of Class PhysitianScheduleController

using Backend.Dto;
using Model.Accounts;
using Model.Schedule;
using System;
using System.Collections.Generic;

namespace Backend.Controller
{
   public class PhysitianScheduleController
   {
      private Physitian loggedPhysitian;
      
      public List<Appointment> GetAppointmentsByDate(DateTime date)
      {
         throw new NotImplementedException();
      }
      
      public Appointment NextAppointment()
      {
         throw new NotImplementedException();
      }
      
      public void NewAppointment(AppointmentDTO appointmentDTO)
      {
         throw new NotImplementedException();
      }
      
      public Backend.Service.PhysitianScheduleService physitianScheduleService;
   
   }
}