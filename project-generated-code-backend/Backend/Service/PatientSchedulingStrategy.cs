// File:    PatientSchedulingStrategy.cs
// Author:  Luka Doric
// Created: Sunday, June 7, 2020 4:19:02 PM
// Purpose: Definition of Class PatientSchedulingStrategy

using Backend.Dto;
using System;

namespace Backend.Service
{
    public class PatientSchedulingStrategy : SchedulingStrategy
    {
        public AppointmentDTO PrepareAppointment(AppointmentDTO appointment)
        {
            throw new NotImplementedException();
        }
    }
}