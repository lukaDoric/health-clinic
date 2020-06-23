// File:    DatePriorityStrategy.cs
// Author:  Luka Doric
// Created: Sunday, June 7, 2020 4:19:02 PM
// Purpose: Definition of Class DatePriorityStrategy

using Model.Schedule;
using Model.Util;
using System;
using System.Collections.Generic;

namespace Backend.Service
{
   public class DatePriorityStrategy : PriorityStrategy
   {
      private TimeInterval timeInterval;

        public List<Appointment> FindSuggestedAppointments()
        {
            throw new NotImplementedException();
        }

    }
}