// File:    SchedulingStrategy.cs
// Author:  Luka Doric
// Created: Sunday, June 7, 2020 4:19:02 PM
// Purpose: Definition of Interface SchedulingStrategy

using System;

namespace Backend.Service
{
   public interface SchedulingStrategy
   {
      AppointmentDTO PrepareAppointment(AppointmentDTO appointment);
   
   }
}