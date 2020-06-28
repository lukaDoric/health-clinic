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

        public void NewAppointment(AppointmentDTO appointmentDTO)
        {
            throw new NotImplementedException();
        }
        public List<Appointment> GetAppointmentsByDate(DateTime date)
        {
            List<Appointment> appointments = new List<Appointment>();
            foreach (Appointment appointment in appointmentRepository.GetAppointmentsByPhysitian(loggedPhysitian))
            {
                if (date.Equals(appointment.Date))
                {
                    appointments.Add(appointment);
                }
            }
            return appointments;
        }
        public Appointment GetTodaysAppointmentForPatient(Patient patient)
        {
            List<Appointment> appointments = appointmentRepository.GetAppointmentsByPatient(patient);
            foreach (Appointment appointment in appointments)
            {
                if (patient.Equals(appointment.Patient))
                {
                    return appointment;
                }
            }
            return null;
        }
        public Appointment GetPreviousAppointmentForPatient(Patient patient)
        {
            throw new NotImplementedException();
        }
        public Appointment GetNextAppointmentForPatient(Patient patient)
        {
            throw new NotImplementedException();
        }

    }
}