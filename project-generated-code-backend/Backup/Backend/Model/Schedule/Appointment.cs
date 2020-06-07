// File:    Appointment.cs
// Author:  Luka Doric
// Created: Sunday, June 7, 2020 4:19:02 PM
// Purpose: Definition of Class Appointment

using System;

namespace Backend.Model.Schedule
{
   public class Appointment
   {
      private Backend.Model.Hospital.Room room;
      private Backend.Model.Accounts.Physitian physitian;
      private Backend.Model.Accounts.Patient patient;
      private Backend.Model.Util.TimeInterval timeInterval;
      private ProcedureType procedureType;
   
   }
}