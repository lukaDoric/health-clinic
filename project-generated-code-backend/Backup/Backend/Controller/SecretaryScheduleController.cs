// File:    SecretaryScheduleController.cs
// Author:  Luka Doric
// Created: Sunday, June 7, 2020 4:19:02 PM
// Purpose: Definition of Class SecretaryScheduleController

using System;

namespace Backend.Controller
{
   public abstract class SecretaryScheduleController
   {
      public void EditAppointment(Backend.Model.Schedule.Appointment appointment)
      {
         throw new NotImplementedException();
      }
      
      public void DeleteAppointment(Backend.Model.Schedule.Appointment appointment)
      {
         throw new NotImplementedException();
      }
      
      public Backend.Model.Schedule.Appointment GetAppointmentsByDate(DateTime date)
      {
         throw new NotImplementedException();
      }
      
      public void NewAppointment(AppointmentDTO appointmentDTO)
      {
         throw new NotImplementedException();
      }
      
      public abstract AppointmentGeneralitiesDTO GetUpdatedAppointmentGeneralities(Backend.Dto.AppointmentDTO appointmentDTO);
      
      public abstract AppointmentDTO GetRecommendedAppointment(Backend.Dto.AppointmentDTO appointmentDTO);
      
      public Backend.Service.AppointmentService appointmentService;
      public Backend.Service.AppointmentSchedulingService appointmentSchedulingService;
   
   }
}