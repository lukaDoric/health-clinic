// File:    PriorityStrategy.cs
// Author:  Luka Doric
// Created: Sunday, June 7, 2020 4:19:02 PM
// Purpose: Definition of Interface PriorityStrategy

using System;

namespace Backend.Service
{
   public interface PriorityStrategy
   {
      List<Appointment> FindSuggestedAppointments();
   
   }
}