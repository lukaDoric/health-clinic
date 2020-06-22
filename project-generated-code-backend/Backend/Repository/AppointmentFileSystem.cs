// File:    AppointmentFileSystem.cs
// Author:  Luka Doric
// Created: Sunday, June 7, 2020 4:19:02 PM
// Purpose: Definition of Class AppointmentFileSystem

using Model.Accounts;
using Model.Hospital;
using Model.Schedule;
using System;
using System.Collections.Generic;

namespace Backend.Repository
{
    public class AppointmentFileSystem : GenericFileRepository<Appointment>, AppointmentRepository
    {
        public List<Appointment> GetAppointmentsByDate(DateTime date)
        {
            throw new NotImplementedException();
        }

        public List<Appointment> GetAppointmentsByPhysitian(Physitian physitian)
        {
            throw new NotImplementedException();
        }

        public List<Appointment> GetAppointmentsByRoom(Room room)
        {
            throw new NotImplementedException();
        }
    }
}