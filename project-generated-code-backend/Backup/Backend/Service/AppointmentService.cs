// File:    AppointmentService.cs
// Author:  Luka Doric
// Created: Sunday, June 7, 2020 4:19:02 PM
// Purpose: Definition of Class AppointmentService

using System;

namespace Backend.Service
{
   public class AppointmentService
   {
      public void EditAppointment(Backend.Model.Schedule.Appointment appointment)
      {
         throw new NotImplementedException();
      }
      
      public void DeleteAppointment(Backend.Model.Schedule.Appointment appointment)
      {
         throw new NotImplementedException();
      }
      
      public List<Appointment> GetAppointmentsByDate(DateTime date)
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