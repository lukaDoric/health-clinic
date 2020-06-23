// File:    PatientScheduleController.cs
// Author:  Luka Doric
// Created: Sunday, June 7, 2020 4:19:02 PM
// Purpose: Definition of Class PatientScheduleController

using Backend.Dto;
using Model.Schedule;
using System;
using System.Collections.Generic;

namespace Backend.Controller
{
   public abstract class PatientScheduleController
   {
      public void EditAppointment(Appointment appointment)
      {
         throw new NotImplementedException();
      }
      
      public void DeleteAppointment(Appointment appointment)
      {
         throw new NotImplementedException();
      }
      
      public Appointment GetAppointmentsByDate(DateTime date)
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