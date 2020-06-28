// File:    AppointmentSchedulingService.cs
// Author:  Luka Doric
// Created: Sunday, June 7, 2020 4:19:02 PM
// Purpose: Definition of Class AppointmentSchedulingService

using Backend.Dto;
using Model.Accounts;
using Model.Hospital;
using Model.Util;
using Backend.Service.SchedulingService.SchedulingStrategies;
using System;
using System.Collections.Generic;
using Backend.Service.SchedulingService.AppointmentGeneralitiesOptions;

namespace Backend.Service.SchedulingService
{
    public class AppointmentSchedulingService
    {
        private SchedulingStrategy schedulingStrategyContext;
        private AppointmentGeneralitiesManager appointmentGeneralitiesManager;

        public AppointmentSchedulingService(SchedulingStrategy schedulingStrategyContext)
        {
            this.schedulingStrategyContext = schedulingStrategyContext;
            this.appointmentGeneralitiesManager = new AppointmentGeneralitiesManager();
        }

        public List<AppointmentDTO> GetAvailableAppointments(AppointmentDTO appointmentPreferences)
        {
            AppointmentDTO preparedAppointmentPreferences = schedulingStrategyContext.PrepareAppointment(appointmentPreferences);
            return appointmentGeneralitiesManager.GetAllAvailableAppointments(preparedAppointmentPreferences);
        }
        public AppointmentDTO FindNearestAppointment(AppointmentDTO appointmentPreferences)
        {
            AppointmentDTO preparedAppointmentPreferences = schedulingStrategyContext.PrepareAppointment(appointmentPreferences);
            throw new NotImplementedException();
        }
        public AppointmentDTO GetSuggestedAppointment(AppointmentDTO appointmentPreferences)
        {
            AppointmentDTO preparedAppointmentPreferences = schedulingStrategyContext.PrepareAppointment(appointmentPreferences);
            throw new NotImplementedException();
        }

    }
}