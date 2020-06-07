// File:    PatientScheduleController.cs
// Author:  Luka Doric
// Created: Sunday, June 7, 2020 4:19:02 PM
// Purpose: Definition of Class PatientScheduleController

using System;

namespace Backend.Controller
{
   public abstract class PatientScheduleController
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
      
      public void NewAppointment(Backend.Dto.AppointmentDTO appointmentDTO)
      {
         throw new NotImplementedException();
      }
      
      public Backend.Dto.AppointmentDTO GetSuggestedAppointment(String physitiansID, List<DateTime> dates, int prior)
      {
         throw new NotImplementedException();
      }
      
      public abstract AppointmentGeneralitiesDTO GetUpdatedAppointmentGeneralities(Backend.Dto.AppointmentDTO appointmentDTO);
      
      public Backend.Service.AppointmentService appointmentService;
      public Backend.Service.AppointmentSchedulingService appointmentSchedulingService;
   
   }
}