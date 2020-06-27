// File:    AppointmentService.cs
// Author:  Luka Doric
// Created: Sunday, June 7, 2020 4:19:02 PM
// Purpose: Definition of Class AppointmentService

using Backend.Dto;
using Backend.Repository;
using Model.Schedule;
using System;
using System.Collections.Generic;

namespace Backend.Service.SchedulingService
{
    public class AppointmentService
    {
        public AppointmentRepository appointmentRepository;

        public AppointmentService()
        {
            appointmentRepository = new AppointmentFileSystem();
        }

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
            List<Appointment> appointmentsByDate = new List<Appointment>();
            List<Appointment> allAppointments = appointmentRepository.GetAll();
            foreach (Appointment a in allAppointments)
            {
                if (a.TimeInterval.Start.Date.Equals(date))
                {
                    appointmentsByDate.Add(a);
                }
            }
            return appointmentsByDate;
        }

        public void NewAppointment(AppointmentDTO appointmentDTO)
        {
            throw new NotImplementedException();
        }

    }
}