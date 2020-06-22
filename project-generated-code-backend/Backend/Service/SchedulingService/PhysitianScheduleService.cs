// File:    PhysitianScheduleService.cs
// Author:  Luka Doric
// Created: Sunday, June 7, 2020 4:19:02 PM
// Purpose: Definition of Class PhysitianScheduleService

using Backend.Dto;
using Model.Schedule;
using System;
using System.Collections.Generic;

namespace Backend.Service.SchedulingService
{
    public class PhysitianScheduleService
    {
        private Model.Accounts.Physitian loggedPhysitian;

        public List<Appointment> GetAppointmentsByDate(DateTime date)
        {
            throw new NotImplementedException();
        }

        public Model.Schedule.Appointment NextAppointment()
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