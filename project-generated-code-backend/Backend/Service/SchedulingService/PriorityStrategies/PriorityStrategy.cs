// File:    PriorityStrategy.cs
// Author:  Luka Doric
// Created: Sunday, June 7, 2020 4:19:02 PM
// Purpose: Definition of Interface PriorityStrategy

using Model.Schedule;
using System;
using System.Collections.Generic;

namespace Backend.Service.SchedulingService.PriorityStrategies
{
    public interface PriorityStrategy
    {
        List<Appointment> FindSuggestedAppointments();

    }
}