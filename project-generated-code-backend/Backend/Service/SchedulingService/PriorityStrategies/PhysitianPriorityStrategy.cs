// File:    PhysitianPriorityStrategy.cs
// Author:  Luka Doric
// Created: Sunday, June 7, 2020 4:19:02 PM
// Purpose: Definition of Class PhysitianPriorityStrategy

using Backend.Model.Schedule;
using System;
using System.Collections.Generic;

namespace Backend.Service.SchedulingService.PriorityStrategies
{
    public class PhysitianPriorityStrategy : PriorityStrategy
    {
        private Backend.Model.Accounts.Physitian physitian;

        public List<Appointment> FindSuggestedAppointments()
        {
            throw new NotImplementedException();
        }
    }
}