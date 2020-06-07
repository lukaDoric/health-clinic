// File:    AppointmentRepository.cs
// Author:  Luka Doric
// Created: Sunday, June 7, 2020 4:19:02 PM
// Purpose: Definition of Interface AppointmentRepository

using System;

namespace Backend.Repository
{
   public interface AppointmentRepository : GenericRepository<T>
   {
      List<Appointment> GetAppointmentsByDate(DateTime date);
      
      List<Appointment> GetAppointmentsByPhysitian(Backend.Model.Accounts.Physitian physitian);
      
      List<Appointment> GetAppointmentsByRoom(Backend.Model.Hospital.Room room);
   
   }
}