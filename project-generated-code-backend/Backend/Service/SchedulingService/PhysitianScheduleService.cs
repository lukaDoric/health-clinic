// File:    PhysitianScheduleService.cs
// Author:  Luka Doric
// Created: Sunday, June 7, 2020 4:19:02 PM
// Purpose: Definition of Class PhysitianScheduleService

using Backend.Dto;
using Backend.Repository;
using Model.Accounts;
using Model.Schedule;
using System;
using System.Collections.Generic;

namespace Backend.Service.SchedulingService
{
    public class PhysitianScheduleService
    {
        private Physitian loggedPhysitian;
        private AppointmentRepository appointmentRepository;

        public PhysitianScheduleService(Physitian loggedPhysitian)
        {
            this.loggedPhysitian = loggedPhysitian;
            this.appointmentRepository = new AppointmentFileSystem();
        }

        public List<Appointment> GetAppointmentsByDate(DateTime date)
        {
            throw new NotImplementedException();
        }

        public void NewAppointment(AppointmentDTO appointmentDTO)
        {
            throw new NotImplementedException();
        }
    }
}