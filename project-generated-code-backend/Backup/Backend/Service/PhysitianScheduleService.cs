// File:    PhysitianScheduleService.cs
// Author:  Luka Doric
// Created: Sunday, June 7, 2020 4:19:02 PM
// Purpose: Definition of Class PhysitianScheduleService

using System;

namespace Backend.Service
{
   public class PhysitianScheduleService
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
      
      public Backend.Repository.AppointmentRepository appointmentRepository;
   
   }
}