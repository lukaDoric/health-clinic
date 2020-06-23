// File:    AppointmentService.cs
// Author:  Luka Doric
// Created: Sunday, June 7, 2020 4:19:02 PM
// Purpose: Definition of Class AppointmentService

using Backend.Dto;
using Model.Schedule;
using System;
using System.Collections.Generic;

namespace Backend.Service
{
   public class AppointmentService
   {
      public void EditAppointment(Appointment appointment)
      {
         throw new NotImplementedException();
      }
      
      public void DeleteAppointment(Appointment appointment)
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