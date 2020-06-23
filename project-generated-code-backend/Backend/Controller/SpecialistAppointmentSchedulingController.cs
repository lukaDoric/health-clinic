// File:    SpecialistAppointmentSchedulingController.cs
// Author:  Luka Doric
// Created: Sunday, June 7, 2020 4:19:02 PM
// Purpose: Definition of Class SpecialistAppointmentSchedulingController

using Backend.Dto;
using Model.Accounts;
using Model.MedicalExam;
using System;

namespace Backend.Controller
{
   public abstract class SpecialistAppointmentSchedulingController
   {
      private Physitian loggedPhysitian;
      private Report currentReport;
      
      public abstract AppointmentGeneralitiesDTO GetUpdatedAppointmentGeneralities(Backend.Dto.AppointmentDTO appointmentDTO);
      
      public abstract AppointmentDTO GetRecommendedAppointment(Backend.Dto.AppointmentDTO appointmentDTO);
      
      public Backend.Service.AppointmentSchedulingService appointmentSchedulingService;
   
   }
}