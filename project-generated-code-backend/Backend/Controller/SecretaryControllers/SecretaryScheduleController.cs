// File:    SecretaryScheduleContoller.cs
// Author:  Luka Doric
// Created: Sunday, June 7, 2020 4:19:02 PM
// Purpose: Definition of Class SecretaryScheduleController

using Backend.Dto;
using Backend.Service.SchedulingService;
using Model.Schedule;
using System;

namespace Backend.Controller.SecretaryControllers
{
    public class SecretaryScheduleController
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

        public void NewAppointment(AppointmentDTO appointmentDTO)
        {
            throw new NotImplementedException();
        }

        public AppointmentGeneralitiesDTO GetUpdatedAppointmentGeneralities(AppointmentDTO appointmentDTO)
        {
            throw new NotImplementedException();
        }

        public AppointmentDTO GetRecommendedAppointment(AppointmentDTO appointmentDTO)
        {
            throw new NotImplementedException();
        }

        public AppointmentService appointmentService;
        public AppointmentSchedulingService appointmentSchedulingService;

    }
}