// File:    FollowUpAppointmentSchedulingController.cs
// Author:  Luka Doric
// Created: Sunday, June 7, 2020 4:19:02 PM
// Purpose: Definition of Class FollowUpAppointmentSchedulingController

using Backend.Dto;
using Backend.Service.SchedulingService;
using Model.Accounts;
using Model.MedicalExam;
using System;

namespace Backend.Controller.PhysitianControllers
{
   public abstract class FollowUpAppointmentSchedulingController
   {
      private Physitian loggedPhysitian;
      private Report currentReport;
      
      public abstract AppointmentGeneralitiesDTO GetUpdatedAppointmentGeneralities(Backend.Dto.AppointmentDTO appointmentDTO);
      
      public abstract AppointmentDTO GetRecommendedAppointment(Backend.Dto.AppointmentDTO appointmentDTO);
      
      public AppointmentSchedulingService appointmentSchedulingService;
   
   }
}