// File:    PhysitianPriorityStrategy.cs
// Author:  Luka Doric
// Created: Sunday, June 7, 2020 4:19:02 PM
// Purpose: Definition of Class PhysitianPriorityStrategy

using Model.Schedule;
using System;
using System.Collections.Generic;

namespace Backend.Service.SchedulingService.PriorityStrategies
{
    public class PhysitianPriorityStrategy : PriorityStrategy
    {
        private Model.Accounts.Physitian physitian;

        public List<Appointment> FindSuggestedAppointments()
        {
            throw new NotImplementedException();
        }
    }
}