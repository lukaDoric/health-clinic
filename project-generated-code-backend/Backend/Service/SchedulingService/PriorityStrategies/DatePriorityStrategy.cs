// File:    DatePriorityStrategy.cs
// Author:  Luka Doric
// Created: Sunday, June 7, 2020 4:19:02 PM
// Purpose: Definition of Class DatePriorityStrategy

using Model.Schedule;
using System;
using System.Collections.Generic;

namespace Backend.Service.SchedulingService.PriorityStrategies
{
    public class DatePriorityStrategy : PriorityStrategy
    {
        private Model.Util.TimeInterval timeInterval;

        public List<Appointment> FindSuggestedAppointments()
        {
            throw new NotImplementedException();
        }

    }
}